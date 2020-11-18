using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class ManualData
    {

        public bool IsHome { get; set; }

        public float MotorWorkPos { get; set; }

        public int MotorSpeed { get; set; }

        public int MannualSetWaterPres { get; set; }

        public int MannualSetFreq { get; set; }

        public int WaterSet { get; set; }

        public int WaterCompensation { get; set; }

        public int PumpPresMax  { get; set; }

        public int PumpPresMin { get; set; }

        public int LowFreq { get; set; }

        public int DampingTime{ get; set; }

        public int WashSetTime { get; set; }

    }
}
