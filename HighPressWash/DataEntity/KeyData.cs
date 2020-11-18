using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class KeyData
    {
        public int Id { get; set; }

        public string EquipmentNum { get; set; }

        public int BuildOperatorNum { get; set; }

        public string KeyInformation { get; set; }

        public DateTime KeyRecordTime { get; set; }

        public int WorkbenchNum { get; set; }

        public string EquipmentStation { get; set; }

        public int EquipmentStationNum { get; set; }

        public string Remarks { get; set; }
    }
}
