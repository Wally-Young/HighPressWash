using EquipmentNetSDK;
using HslCommunication;
using HslCommunication.Controls;
using HslCommunication.ModBus;
using HZH_Controls.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HighPressWash
{
    public partial class MainFrm : Form
    {

        public MainFrm()
        {
            InitializeComponent();
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 5);
            tabControl1.Appearance = TabAppearance.FlatButtons;

            CBmotorMove.ForeColor = Color.White;
            ucRadioButton2.ForeColor = Color.White;
            ucRadioButton3.ForeColor = Color.White;
            ucRadioButton4.ForeColor = Color.White;
            ucRadioButton5.ForeColor = Color.White;
            ucRadioButton6.ForeColor = Color.White;
            ucRadioButton7.ForeColor = Color.White;
            ucRadioButton8.ForeColor = Color.White;
        }

        #region Fields
        private ModbusTcpNet busTcpClient;  // 站号1
        private JObject alarmJson;
        private JObject CgInfo;
        private Thread readThread;
        private bool IsConnected;
        private List<bool> ManulDataBtnFeedBack=new List<bool>();
        private HomeData homeData = new HomeData();
        private ManualData manualData = new ManualData();
        List<UserButton> userButtons;
        private bool IsNetConnected;
        private List<bool> alarmdata = new List<bool>(new bool[45]);
        private List<bool> alarmdataOld = new List<bool>(new bool[45]);
        private List<AlarmInfo> AlarmInfos = new List<AlarmInfo>();
        private List<AlarmInfo> HistoryAlarmInfos = new List<AlarmInfo>();
        List<UCValve> uCValves = new List<UCValve>();
        public static string equipmentName = "";

        public static string ProductType = "";

        public static TaskParameter taskParameters;

        public static List<WashParameter> washParameters=new List<WashParameter>();
        private int currentPage = 0;

        private bool IsPres;
        Dictionary<string, Color> equipMentState = new Dictionary<string, Color>()
        {
            ["待机中"] = Color.Yellow,
            ["启动中"] = Color.Green,
            ["清洗中"] = Color.LawnGreen,
            ["暂停中"] = Color.LightYellow,
            ["清洗完成"] = Color.Yellow,
            ["未知/未启动"] = Color.Gray,
            ["报警中"] = Color.Red,
        };
        private bool IsPres1;

        #endregion

        #region Initial

        /// <summary>
        /// 窗体加载初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            #region 初始化PLC
           
            try
            {
                string jsonText = File.ReadAllText("server.json");
                CgInfo = (JObject)JsonConvert.DeserializeObject(jsonText);
                alarmJson = (JObject)JsonConvert.DeserializeObject(File.ReadAllText("error.json"));                       
                busTcpClient = new ModbusTcpNet(CgInfo["IP"].ToString(), int.Parse(CgInfo["Port"].ToString()),byte.Parse( CgInfo["ID"].ToString()));
                busTcpClient.DataFormat = HslCommunication.Core.DataFormat.CDAB;
                Task.Run(() =>
                {
                    OperateResult result = busTcpClient.ConnectServer();
                    IsConnected = result.IsSuccess;
                });
               
               
               // lampPLCConnected.LampColor[0] = result.IsSuccess ? Color.LawnGreen : Color.Gray;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"加载上次参数失败!原因:{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            #region 初始化线程读取
            readThread = new Thread(() => ReadData());
            readThread.IsBackground = true;
            readThread.Start();

            #endregion

            #region 加载设备参数
            try
            {
                //if (File.Exists("deviceParams.json"))
                //{
                //    TaskParams = JsonConvert.DeserializeObject<FatigueTaskParameter>(File.ReadAllText("deviceParams.json"));

                //    this.ProductType = TaskParams.ProductType;
                //    this.VersionTime = TaskParams.VersionTime;
                //}

                //if (File.Exists("injectorParams.json"))
                //{
                //    List<InjectorParameter> injectors = JsonConvert.DeserializeObject<List<InjectorParameter>>(File.ReadAllText("injectorParams.json"));
                //    for (int i = 0; i < InjectorParameter1.Count; i++)
                //    {
                //        var injfd = injectors.Find(x => x.WorkGroupNum == 1 && x.LineNum == InjectorParameter1[i].LineNum);
                //        if (injfd != null)
                //        {
                //            InjectorParameter1[i] = injfd;
                //        }
                //    }

                //    for (int i = 0; i < InjectorParameter2.Count; i++)
                //    {
                //        var injfd = injectors.Find(x => x.WorkGroupNum == 2 && x.LineNum == InjectorParameter2[i].LineNum);
                //        if (injfd != null)
                //        {
                //            InjectorParameter2[i] = injfd;
                //        }
                //    }

                //    var w1 = injectors.Find(x => x.WorkGroupNum == 1);
                //    if (w1 != null)
                //    {
                //        WorkingParamter1 = w1.GetGroupParameter();
                //    }

                //    var w2 = injectors.Find(x => x.WorkGroupNum == 2);
                //    if (w2 != null)
                //    {
                //        WorkingParamter2 = w2.GetGroupParameter();
                //    }
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show($"加载上次参数失败!原因:{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion


            timer1.Interval = 500;
            timer1.Enabled = true;
            userButtons = new List<UserButton>{
                BtnGasVel1,BtnGasVel2, BtnGasVel3 , BtnGasVel4,  BtnGasVel5 , BtnGasVel6 ,
                BtnWash1,  BtnWash2,  BtnWash3,  BtnWash4,  BtnWash5,  BtnWash6
                ,BtnOverVel,BtnHighPres

           };
            uCValves = new List<UCValve>
            {
                AirVavel1,AirVavel2,AirVavel3,AirVavel4,AirVavel5,AirVavel6,
                WaterVaVel1,WaterVaVel2,WaterVaVel3,WaterVaVel4,WaterVaVel5,WaterVaVel6,
                ucValve1
            };
            if(Program.objCurrentAdmin!=null)
                toolUser.Text = $"当前用户:{Program.objCurrentAdmin.operator_num}";

            for (int i = 0; i < 30; i++)
            {
                washParameters.Add(new WashParameter() { EquipmentNum = equipmentName, ProductType = this.ProductName, EquipmentWashNum = i + 1 });
                washParameters[i].getBools();
            }
            dataGridParam.AutoGenerateColumns = false;
            dataGridParam.DataSource = new BindingList<WashParameter> (washParameters.Skip(currentPage).Take(10).ToList());
            this.dataGridParam.Refresh();
            DGCurrentAlarm.AutoGenerateColumns = false;

        }

        #endregion

        #region RecycleMethod
        private void ReadData()
        {
            while(true)
            {
                if (IsConnected)
                {
                    try
                    {
                        ManulDataBtnFeedBack.Clear();

                        #region 主页
                        OperateResult<short> operateResult = busTcpClient.ReadInt16((1040).ToString());//水压
                        if (operateResult.IsSuccess)
                        {
                            homeData.WashPress = operateResult.Content;
                        }
                        else
                        {
                            IsConnected = false;
                            continue;
                        }

                        homeData.Mode = busTcpClient.ReadCoil((207 + 49408).ToString()).Content;//手动自动模式
                        homeData.EStop = busTcpClient.ReadCoil(510.ToString()).Content;//急停
                        homeData.CurrentPos1 = busTcpClient.ReadInt32((41088 + 200).ToString()).Content;//电机位置1
                        homeData.CurrentPos2 = busTcpClient.ReadInt32((41088 + 202).ToString()).Content;//电机位置2
                        homeData.WashPress = busTcpClient.ReadInt16(1040.ToString()).Content;//冲洗水压
                        homeData.WashStep = busTcpClient.ReadInt16((35 + 41088).ToString()).Content;//冲洗序号
                        homeData.alreadyTime = busTcpClient.ReadInt16((41088 + 120).ToString()).Content;//已冲洗时间
                        homeData.WashSetTime = busTcpClient.ReadInt16((41088 + 115).ToString()).Content;//冲洗设定时间

                        homeData.IsPumpRun = busTcpClient.ReadCoil(20740.ToString()).Content;
                        List<bool> datas = busTcpClient.ReadCoil("330", 5).Content.ToList();
                        homeData.IsAlarm = busTcpClient.ReadCoil("608").Content;
                        datas.Add(homeData.IsAlarm);
                        homeData.EquipmentState(datas.ToArray());

                        homeData.IsReady = busTcpClient.ReadCoil("120").Content;//准备就绪;
                        #endregion

                        #region 手动页面
                        ManulDataBtnFeedBack.AddRange(busTcpClient.ReadCoil((24896 + 2).ToString(), 12).Content);//手动按钮反馈
                                                                                                                 //  ManulDataBtnFeedBack.Add(busTcpClient.ReadCoil((24896 + 1).ToString()).Content);//手动按钮反馈

                        ManulDataBtnFeedBack.Add(busTcpClient.ReadCoil((24896 + 14).ToString()).Content);//手动按钮反馈
                        ManulDataBtnFeedBack.Add(busTcpClient.ReadCoil((24896 + 0).ToString()).Content);//手动按钮反馈

                        manualData.MotorWorkPos = busTcpClient.ReadInt16((41088 + 610).ToString()).Content / 100.0f;//电机工作位置
                        manualData.MotorSpeed = busTcpClient.ReadInt16((41088 + 609).ToString()).Content;//电机速度

                        manualData.MannualSetWaterPres = busTcpClient.ReadInt16((41088 + 27).ToString()).Content;//手动水压设定（KPa）
                        manualData.MannualSetFreq = busTcpClient.ReadInt16((41088 + 28).ToString()).Content;//手动频率设定（Hz）

                        manualData.WaterSet = busTcpClient.ReadInt16((41088 + 10).ToString()).Content;
                        manualData.WaterCompensation = busTcpClient.ReadInt16((41088 + 15).ToString()).Content;
                        manualData.PumpPresMax = busTcpClient.ReadInt16((41088 + 11).ToString()).Content;
                        manualData.PumpPresMin = busTcpClient.ReadInt16((41088 + 12).ToString()).Content;
                        manualData.LowFreq = busTcpClient.ReadInt16((41088 + 23).ToString()).Content;
                        manualData.DampingTime = busTcpClient.ReadInt16((41088 + 25).ToString()).Content;
                        manualData.WashSetTime = busTcpClient.ReadInt32((41088 + 115).ToString()).Content;
                        #endregion

                        #region 报警信息
                       if (homeData.IsAlarm)
                       // if (true)
                        {
                            alarmdata = busTcpClient.ReadCoil("780", 45).Content.ToList();//错误
                            for (int i = 0; i < alarmdata.Count; i++)
                            {
                                if (alarmdata[i])
                                {
                                    if (!AlarmInfos.ToList().Exists(x => x.TriggerValue == "M" + (780 + i).ToString()))
                                    {
                                        AlarmInfo alarmInfo = new AlarmInfo();
                                        alarmInfo.Description = alarmJson["M" + (780 + i).ToString()].ToString();
                                        alarmInfo.BeginTime = DateTime.Now;
                                        alarmInfo.TriggerValue = "M" + (780 + i).ToString();
                                        this.Invoke(new Action(() =>
                                        {
                                            AlarmInfos.Add(alarmInfo);
                                            DGCurrentAlarm.DataSource = null;
                                            DGCurrentAlarm.DataSource = AlarmInfos;
                                           // DGCurrentAlarm.Refresh();
                                        }
                                        ));
                                    }
                                }
                                else
                                {
                                    if (AlarmInfos.ToList().Exists(x => x.TriggerValue == "M" + (780 + i).ToString()))
                                    {
                                        var rs = AlarmInfos.ToList().Find(x => x.TriggerValue == "M" + (780 + i).ToString());
                                        if (rs != null)
                                        {
                                            rs.EndTime = DateTime.Now;
                                            this.Invoke(new Action(
                                                  () =>
                                                  {
                                                      AlarmInfos.Remove(rs);
                                                      DGCurrentAlarm.DataSource = null;
                                                      DGCurrentAlarm.DataSource = AlarmInfos;
                                                      HistoryAlarmInfos.Add(rs);
                                                      if (HistoryAlarmInfos.Count > 100)
                                                          HistoryAlarmInfos.RemoveAt(0);

                                                      DGHistoryAlarm.DataSource = null;
                                                      DGHistoryAlarm.DataSource = new BindingList<AlarmInfo>(HistoryAlarmInfos);
                                                      DGHistoryAlarm.Refresh();
                                                  }
                                                  ));

                                        }
                                    }
                                }


                            }

                        }
                        else
                        {
                            this.Invoke(new Action(() =>
                            {
                                foreach (var item in AlarmInfos)
                                {
                                    item.EndTime = DateTime.Now;
                                    HistoryAlarmInfos.Add(item);
                                    if (HistoryAlarmInfos.Count > 100)
                                    {
                                        HistoryAlarmInfos.RemoveAt(0);
                                    }
                                      
                                    DGHistoryAlarm.DataSource = null;
                                    DGHistoryAlarm.DataSource = new BindingList<AlarmInfo>(HistoryAlarmInfos);
                                    DGHistoryAlarm.Refresh();
                                }
                                AlarmInfos.Clear();
                                DGCurrentAlarm.DataSource = null;
                            }

                            ));
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {

                        IsConnected = false;
                    }
                  

                }
                else
                {
                    IsConnected = busTcpClient.ConnectServer().IsSuccess;

                }
                Thread.Sleep(300);
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ManulDataBtnFeedBack.Count; i++)
                {
                    userButtons[i].OriginalColor = ManulDataBtnFeedBack[i] ? Color.LawnGreen : Color.FromArgb(89, 169, 254);
                }
                for (int i = 0; i < uCValves.Count; i++)
                {
                    uCValves[i].SwitchColor = ManulDataBtnFeedBack[i] ? Color.LawnGreen : Color.FromArgb(232, 30, 99);
                    uCValves[i].LiquidDirection = ManulDataBtnFeedBack[i] ? LiquidDirection.Forward : LiquidDirection.None;
                }
                btnChangeMode.UIText = homeData.Mode ? "自动模式" : "手动模式";
                userButton18.UIText = homeData.Mode ? "自动模式" : "手动模式";
                btnChangeMode.EnableColor = homeData.Mode ? Color.GreenYellow : Color.Gray;

                lbIsReady.Text = homeData.IsReady ? "准备就绪":"未准备好";
                ucBlower1.BlowerColor = homeData.IsPumpRun ? Color.LimeGreen : Color.FromArgb(255, 77, 59);
                if (homeData.EStop)
                {
                    if (DateTime.Now.Second % 3 == 0)
                    {
                        btnEstop.OriginalColor = Color.Yellow;
                    }
                    else
                    {
                        btnEstop.OriginalColor = Color.Red;
                    }
                }
                string conn = IsConnected ? "成功" : "失败";
                toolPLCConnect.Text = $"PLC连接状态: {conn}";
                //判断服务器连接信息
                if (DateTime.Now.Second % 2 == 0)
                    try
                    {
                        Task.Run(() => IsNetConnected = DBManage.GetConnState());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }


                toolServiceStatus.Text = IsNetConnected ? "服务器连接状态: 成功" : "服务器连接状态: 失败";

                #region 位置、压力
                txtPosition1.Text = (homeData.CurrentPos1 / 100.0f).ToString();

                txtPosition2.Text = (homeData.CurrentPos2 / 100.0f).ToString();
                txtWashPress.Text = homeData.WashPress.ToString();

                txtHomePos1.Text = (homeData.CurrentPos1 / 100.0f).ToString();
                txtHomePos2.Text = (homeData.CurrentPos2 / 100.0f).ToString();
                txtHomeWashPress.Text = homeData.WashPress.ToString();
                #endregion

                #region 序号 时间
                txtWashSetTime.Text = txtSetTime.Text = homeData.WashSetTime.ToString();
                txtAlreadyTime.Text = homeData.alreadyTime.ToString();
                txtWashNum.Text = homeData.WashStep.ToString();
                #endregion


                lbEquipmentStatus.Text = homeData.EquipState;
                ucAlarmLamp1.LampColor[0] = equipMentState[homeData.EquipState];
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          

            
       
        }

        #endregion

        #region ButtonEvent

        #region 主页按钮
        /// <summary>
        /// 取反
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            String msg = (sender as UserButton).Tag.ToString();
            if (IsConnected)
            {
                if (msg.Contains("M"))
                {

                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    bool currentrs = busTcpClient.ReadCoil(address.ToString()).Content;
                    busTcpClient.WriteCoil(address.ToString(), !currentrs);
                }
                else if (msg.Contains("H"))
                {
                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    bool currentrs = busTcpClient.ReadCoil((49408 + address).ToString()).Content;
                    busTcpClient.WriteCoil((49408 + address).ToString(), !currentrs);
                }
               
            }
            else
            {
                MessageBox.Show("PLC未连接!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 按下为true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton1_MouseDown(object sender, MouseEventArgs e)
        {
            String msg = (sender as UserButton).Tag.ToString();
            if (IsConnected)
            {
                if (msg.Contains("M"))
                {

                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    busTcpClient.WriteCoil((address).ToString(), true);
                }
                else if (msg.Contains("H"))
                {
                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    busTcpClient.WriteCoil((49408 + address).ToString(), true);
                }
               
            }
            else
            {
                MessageBox.Show("PLC未连接!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 抬起false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton1_MouseUp(object sender, MouseEventArgs e)
        {
            String msg = (sender as UserButton).Tag.ToString();
            if (IsConnected)
            {
                if (msg.Contains("M"))
                {

                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    busTcpClient.WriteCoil((address).ToString(), false);
                }
                else if (msg.Contains("H"))
                {
                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    busTcpClient.WriteCoil((49408 + address).ToString(), false);
                }

            }
            else
            {
                MessageBox.Show("PLC未连接!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 菜单改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuitemHome_Click(object sender, EventArgs e)
        {
            string text = (sender as ToolStripMenuItem).Text;
            if(text=="主页")
            {
                tabControl1.SelectedIndex = 0;
            }
            else if(text=="手动界面")
            {
                tabControl1.SelectedIndex = 1;
                txtSetFreq.Text = manualData.MannualSetFreq.ToString();
                txtSetPres.Text = manualData.MannualSetWaterPres.ToString();
                txtPos.Text = manualData.MotorWorkPos.ToString();
                txtSpeed.Text= manualData.MotorSpeed.ToString();
                EnbleLowFreq.Checked = busTcpClient.ReadCoil((49408 + 10).ToString()).Content;

            }
            else if(text=="参数设置")
            {
                tabControl1.SelectedIndex = 2;
                if(IsConnected)
                {
                    txtSetWaterPres.Text = manualData.WaterSet.ToString();
                    txtWaterCompensate.Text = manualData.WaterCompensation.ToString();
                    txtPresMax.Text = manualData.PumpPresMax.ToString();
                    txtPresMin.Text = manualData.PumpPresMin.ToString();
                    txtLowFreq.Text = manualData.LowFreq.ToString();
                    txtAerify.Text = manualData.DampingTime.ToString();
                    txtWashSetTime.Text = manualData.WashSetTime.ToString();
                    txtAutoStartTime.Text= (busTcpClient.ReadInt16((41088 + 17).ToString()).Content/10).ToString();
                    txtPosLimit.Text= (busTcpClient.ReadInt16((41088 + 122).ToString()).Content / 100).ToString();
                    NegMaxLimit.Text = (busTcpClient.ReadInt16((41088 + 124).ToString()).Content / 100).ToString();
                  
                    if (!IsPres1)
                    {
                        txtIdlePos.Text = (busTcpClient.ReadInt16((41088 + 5010).ToString()).Content/100.0f).ToString();

                        
                    }
                    if(!IsPres)
                        txtWorkPos.Text = (busTcpClient.ReadInt16((41088 + 5011).ToString()).Content/100.0f).ToString();
                    IsPres = false;
                    IsPres1 = false;
                    txtIdleSpeed.Text = busTcpClient.ReadInt16((41088 + 5012).ToString()).Content.ToString();
                   txtWorkSpeed.Text = busTcpClient.ReadInt16((41088 + 5013).ToString()).Content.ToString();
                    txtSystemMaxPres.Text= busTcpClient.ReadInt16((41088 + 22).ToString()).Content.ToString();
                }
               
            }
            else if (text == "报警界面")
            {
                tabControl1.SelectedIndex = 3;
            }

        }


        #endregion

        #region 手动按钮

        /// <summary>
        /// 置位写入参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMannualWrite_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
              
                busTcpClient.Write((41088 + 609).ToString(), short.Parse(txtSpeed.Text));
                busTcpClient.Write((41088 + 27).ToString(), short.Parse(txtSetPres.Text));
                busTcpClient.Write((41088 + 28).ToString(), short.Parse(txtSetFreq.Text));
              
            }
            else
            {
                MessageBox.Show("PLC未连接!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// 电机位置改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBmotorMove_CheckedChangeEvent(object sender, EventArgs e)
        {
            foreach (var item in groupBox5.Controls)
            {
                if (item is UCRadioButton)
                {
                    if (((UCRadioButton)item).Checked)
                    {
                        if (IsConnected)
                        {

                            string value = ((UCRadioButton)item).TextValue.Trim();
                            if (value.Contains("mm"))
                            {
                                int length = value.Length;
                                short pos = (short)(float.Parse(value.Substring(0, length - 2)) * 1000.0f);

                                busTcpClient.Write((41088 + 640).ToString(), pos);
                            }

                        }
                    }
                }
            }


        }

        /// <summary>
        /// 手动位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMotorMove_MouseLeave(object sender, EventArgs e)
        {
            if (ucRadioButton7.Checked)
            {
                try
                {
                    if (IsConnected)
                    {
                        short value = short.Parse(txtMotorMove.Text);
                        busTcpClient.Write((41088 + 640).ToString(), value);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"数值输入必须为整数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        #endregion

                
        #region 参数写入

        /// <summary>
        /// 清除参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearParam_Click(object sender, EventArgs e)
        {
            busTcpClient.WriteCoil((110).ToString(), true);
            Thread.Sleep(100);
            busTcpClient.WriteCoil((110).ToString(), false);
            washParameters.Clear();
            
            for (int i = 0; i < 30; i++)
            {
               
                washParameters.Add(new WashParameter() { EquipmentNum = equipmentName, ProductType = this.ProductName, EquipmentWashNum = i + 1 });
               
            }
            foreach (var item in tabPage4.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        /// <summary>
        ///下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            if (currentPage > 2)
                currentPage = 2;
            dataGridParam.DataSource = null;
            dataGridParam.DataSource = new BindingList<WashParameter>(washParameters.Skip(currentPage * 10).Take(10).ToList());
            this.dataGridParam.Refresh();
        }
        
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;
            if (currentPage < 0)
                currentPage = 0;
            dataGridParam.DataSource = null;
            dataGridParam.DataSource = new BindingList<WashParameter>(washParameters.Skip(currentPage * 10).Take(10).ToList());
            this.dataGridParam.Refresh();
        }

        /// <summary>
        /// 下载参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadDownParam_Click(object sender, EventArgs e)
        {
            LoadDownParam downParam = new LoadDownParam();
            downParam.ShowDialog();

        }

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveParam_Click(object sender, EventArgs e)
        {
            if(IsConnected)
            {
                for (int i = 0; i < 30; i++)
                {
                      if(IsConnected)
                    {
                        bool[] datas = washParameters[i].getBools();
                        busTcpClient.WriteCoil((49408 + 240 + i * 12).ToString(), datas);
                        busTcpClient.Write((41088 + 50 + 2 * i).ToString(), washParameters[i].Time * 10);
                    }

                }

                try
                {
                    busTcpClient.Write((41088 + 10).ToString(), short.Parse(txtSetWaterPres.Text));
                    busTcpClient.Write((41088 + 15).ToString(), short.Parse(txtWaterCompensate.Text));
                    busTcpClient.Write((41088 + 11).ToString(), short.Parse(txtPresMax.Text));
                    busTcpClient.Write((41088 + 12).ToString(), short.Parse(txtPresMin.Text));

                    busTcpClient.Write((41088 + 23).ToString(), short.Parse(txtLowFreq.Text));

                    busTcpClient.Write((41088 + 25).ToString(), short.Parse(txtAerify.Text));

                    busTcpClient.Write((41088 + 115).ToString(), int.Parse(txtWashSetTime.Text));

                    busTcpClient.WriteCoil((49408 + 10).ToString(), EnbleLowFrequency.Checked);
                    busTcpClient.Write((41088 + 5010).ToString(), (short)(float.Parse(txtIdlePos.Text) * 100));
                    busTcpClient.Write((41088 + 5011).ToString(), (short)(float.Parse(txtWorkPos.Text) * 100));

                    busTcpClient.Write((41088 + 5012).ToString(), short.Parse(txtIdleSpeed.Text));
                    busTcpClient.Write((41088 + 5013).ToString(), short.Parse(txtWorkSpeed.Text));
                    busTcpClient.Write((41088 + 22).ToString(), short.Parse(txtSystemMaxPres.Text));

                    busTcpClient.Write((41088 + 17).ToString(), (short)(short.Parse(txtAutoStartTime.Text) * 10));
                    busTcpClient.Write((41088 + 122).ToString(), (short)(float.Parse(txtPosLimit.Text) * 100));
                    busTcpClient.Write((41088 + 124).ToString(), (short)(float.Parse(NegMaxLimit.Text) * 100));

                    busTcpClient.WriteCoil((13).ToString(), true);
                    Thread.Sleep(100);
                    busTcpClient.WriteCoil((13).ToString(), false);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"参数输入错误,请注意参数的范围!{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
          

        }


        #endregion

        #endregion

  
        private void BtnToStandy_Click(object sender, EventArgs e)
        {
            this.txtIdlePos.Text = (homeData.CurrentPos1/100.0f).ToString();
            IsPres1 = true;
        }

        private void BtnToWorkPos_Click(object sender, EventArgs e)
        {
            this.txtWorkPos.Text = (homeData.CurrentPos1 / 100.0f).ToString();
            this.txtPos.Text = (homeData.CurrentPos1 / 100.0f).ToString();
            IsPres = true;
        }

        private void txtPos_MouseLeave(object sender, EventArgs e)
        {

        }

        private void EnbleLowFreq_CheckedChanged(object sender, EventArgs e)
        {
            busTcpClient.WriteCoil((49408 + 11).ToString(), EnbleLowFreq.Checked);
        }

        private void WaterVaVel3_Click(object sender, EventArgs e)
        {
            String msg = (sender as UCValve).Tag.ToString();
            if (IsConnected)
            {
                if (msg.Contains("M"))
                {

                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    bool currentrs = busTcpClient.ReadCoil(address.ToString()).Content;
                    busTcpClient.WriteCoil(address.ToString(), !currentrs);
                }
                else if (msg.Contains("H"))
                {
                    int address = int.Parse(msg.Substring(1, msg.Length - 1));

                    bool currentrs = busTcpClient.ReadCoil((49408 + address).ToString()).Content;
                    busTcpClient.WriteCoil((49408 + address).ToString(), !currentrs);
                }

            }
            else
            {
                MessageBox.Show("PLC未连接!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void txtSetPres_KeyDown(object sender, KeyEventArgs e)
       {
            if(e.KeyCode==Keys.Enter)
            {
                if (IsConnected)
                {
                    string txt = (sender as TextBox).Text;
                    string tag = (sender as TextBox).Tag.ToString();

                    if (!String.IsNullOrEmpty(txt.Trim()))
                    {
                        int data = int.Parse(tag);
                        if ((sender as TextBox).Name == "txtPos")
                        {
                            short value = (short)(float.Parse(txt) * 100);
                            busTcpClient.Write((41088 + data).ToString(), value);
                        }
                        else
                            busTcpClient.Write((41088 + data).ToString(), short.Parse(txt));
                    }
                }
            }
        }
    }
}
