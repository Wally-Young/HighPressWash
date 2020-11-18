using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public  class EquipmentStateData
    {

        public int Id { get; set; }

        public string EquipmentNum { get; set; }

        public string ProductType { get; set; }

        public string TaskParVersionTime { get; set; }

        public int BuildOperatorNum { get; set; }

        public int EquipmentPressure { get; set; }

        public string EquipmentState { get; set; }

        public DateTime RecordTime { get; set; }

        public string Remarks { get; set; }


    }
}
