using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class AlarmData
    {
        public int Id { get; set; }

        public string EquipmentNum { get; set; }

        public string ProductType { get; set; }

        public string TaskParVersionTime { get; set; }

        public string BasicParVersionTime { get; set; }

        public int BuildOperatorNum { get; set; }

        public string AlarmInformation { get; set; }

        public DateTime RecordTime { get; set; }

        public int WorkbenchNum { get; set; }

        public string EquipmentStation { get; set; }

        public string ProductCode { get; set; }

        public string Remarks { get; set; }

    }
}
