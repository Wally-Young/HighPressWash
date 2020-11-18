
using EquipmentNetSDK;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighPressWash
{
    public partial class LogFrm : Form
    {
       
        public LogFrm()
        {
            InitializeComponent();
          
        }

        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //【1】数据验证
            if (this.txtLoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录账号！", "登录提示");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录密码！", "登录提示");
                this.txtLoginPwd.Focus();
                return;
            }
            //Messenger.Default.Send<User>(this.user, "LogSuccess"); //注意：token参数一致 
            try
            {
                string jsonText = File.ReadAllText("server.json");
                JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);

                #region 初始化服务器连接
                DBManage.connectToServer(jo["DataBaseIP"].ToString(), "LabTest", jo["User"].ToString(), jo["Pwd"].ToString());

                DBManage.connectToServerM(jo["DataBaseIP"].ToString(), "LabTest", jo["User"].ToString(), jo["Pwd"].ToString());
                DBManage.GetProQueue();

                bool k = DBManage.GetConnState();
                #endregion
                //Tuple<int, string> result = DBManage.LoginMethod(txtLoginId.Text.Trim(), txtLoginPwd.Text.Trim());
                //string message = "";
                //switch (result.Item1)
                //{
                //    case 0: message = "登录成功!"; break;
                //    case 1: message = "账号不存在!"; break;
                //    case 2: message = "密码不正确!"; break;
                //    case 3: message = "用户已经离职或者已经到使用期限"; break;
                //    default:
                //        break;
                //}
                //MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (result.Item1 == 0 || jo["Debug"].ToString() == "true")
                //{
                //    this.DialogResult = DialogResult.OK;
                //    Program.objCurrentAdmin = JsonConvert.DeserializeObject<User>(result.Item2);
                //}
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录出错:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult options = MessageBox.Show("您确定要退出吗?", "问询", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (options == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }


        #region 改善用户体验

        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (this.txtLoginId.Text.Trim().Length != 0)
                {
                    this.txtLoginPwd.Focus();//将当前的焦点跳转到密码框
                    this.txtLoginPwd.SelectAll();
                }
            }
        }
        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(null, null);//直接调用登录按钮的事件
            }
        }

        #endregion

        private void txtLoginId_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void txtLoginPwd_KeyDown_1(object sender, KeyEventArgs e)
        {

        }
    }
}
