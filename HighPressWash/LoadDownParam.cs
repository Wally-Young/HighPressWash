using EquipmentNetSDK;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighPressWash
{
    public partial class LoadDownParam : Form
    {
        public LoadDownParam()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManage.QueryProdNum(0, MainFrm.equipmentName, this.txtProductName.Text.Trim());
            this.listBox1.DataSource = dt.AsEnumerable().Select(x => x.Field<string>("ProductType")).ToList();
        }

        private void btnLoadDownParam_Click(object sender, EventArgs e)
        {
            Tuple<int, string> tup = DBManage.ALLParaDownJson(0, MainFrm.ProductType, MainFrm.equipmentName);
            if (tup.Item1 == 0)
            {
                DealWithParam(tup.Item2);
                MessageBox.Show("下载成功,从服务器下载", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tup.Item1 == 1)
            {
                DealWithParam(tup.Item2);
                MessageBox.Show("下载成功,从本地下载", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("下载失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            MainFrm.ProductType= listBox1.SelectedItem.ToString();
        }

        private void DealWithParam(string tasks)
        {
            
            string[] tasparams = tasks.Split(';');
            string first = tasparams[0].Substring(1, tasparams[0].Length - 1);
            MainFrm.taskParameters = JsonConvert.DeserializeObject<TaskParameter>(first);

            string second = "";
            if (tasparams[1].Contains("},"))
            {
                second = tasparams[1].Substring(1, tasparams[1].Length - 3);
                second = "[" + second + "]";
            }
            else
            {
                second = tasparams[1];
                second = "[" + second.Substring(0, second.Length - 1) + "]";
            }

            MainFrm.washParameters = JsonConvert.DeserializeObject<List<WashParameter>>(second);
          
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            int result = DBManage.StopProdNum(0, MainFrm.equipmentName,MainFrm.ProductType);
            if (result == 0)
            {
                MessageBox.Show("禁用成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 1)
            {
                MessageBox.Show("服务器禁用成功,本地禁用失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 2)
            {
                MessageBox.Show("禁用失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
