using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class ProductData
    {
        public int Id { get; set; }

        public string ProductType { get; set; }

        public string EquipmentNum { get; set; }

        public string TaskParVersionTime { get; set; }

        public int BuildOperatorNum { get; set; }

        public DateTime CompleteTime { get; set; }

        public int WashTimeTotal { get; set; }

        public int WashPressureMax { get; set; }

        public int WashPressureMin { get; set; }

        public string ProductCode1 { get; set; }

        public string ProductCode2 { get; set; }

        public string ProductCode3 { get; set; }

        public string ProductCode4 { get; set; }

        public string ProductCode5 { get; set; }

        public string ProductCode6 { get; set; }

        public string Remarks { get; set; }

    }
}
