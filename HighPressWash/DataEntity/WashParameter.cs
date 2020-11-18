using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class WashParameter
    {
        public int Id { get; set; }

        public string ProductType { get; set; }

        public string EquipmentNum { get; set; }

        public string UseState { get; set; }

        public string VersionTime { get; set; }

        public DateTime BuildTime { get; set; } = DateTime.Now;

        public int EquipmentWashNum { get; set; }


        public string IsGasValveOpen1 { get; set; } = "否";

        public string IsGasValveOpen2 { get; set; } = "否";

        public string IsGasValveOpen3 { get; set; } = "否";


        public string IsGasValveOpen4 { get; set; } = "否";
        public string IsGasValveOpen5 { get; set; } = "否";
        public string IsGasValveOpen6 { get; set; } = "否";

        public string IsWaterValveOpen1 { get; set; } = "否";

        public string IsWaterValveOpen2 { get; set; } = "否";

        public string IsWaterValveOpen3 { get; set; } = "否";

        public string IsWaterValveOpen4 { get; set; } = "否";

        public string IsWaterValveOpen5 { get; set; } = "否";

        public string IsWaterValveOpen6 { get; set; } = "否";

        public int Time { get; set; }
        public string Remarks { get; set; }

        [JsonIgnore]
        public string StartAddress { get; set; }


        public bool[] getBools()
        {
            List<bool> results = new List<bool>();
            Type t = this.GetType();
            PropertyInfo[] pArray = t.GetProperties();

            var  data=   pArray.Where(x => x.Name.Contains("Is"));

           var data1= data.Select(x => x.GetValue(this,null).ToString() == "是");

            return data1.ToArray();
        }
       
    }
}
