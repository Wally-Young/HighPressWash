using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class TaskParameter
    {
        public int Id { get; set; }

        public string ProductType { get; set; }

        public int ProcessNum { get; set; }

        public string EquipmentNum { get; set; }

        public string UseState { get; set; }

        public string VersionTime { get; set; }

        public int BuildOperatorNum { get; set; }

        public DateTime BuildTime { get; set; }

        public int AnnulOperatorNum { get; set; }

        public DateTime AnnulTime { get; set; }

        public int NetConnectState { get; set; }

        public int TargetPressure { get; set; }

        public int EquipmentPressureMax { get; set; }

        public int WorkPressureMax { get; set; }

        public int WorkPressureMin { get; set; }

        public int WaterPumpFreMax { get; set; }

        public string IsScanCode { get; set; }

        public string Remarks { get; set; }
    }
}
