using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class HomeData
    {
        public int WashPress { get; set; }

        public bool EStop { get; set; }

        public bool Mode { get; set; }

        public int CurrentPos1 { get; set; }

        public int CurrentPos2 { get; set; }

        public int WashStep { get; set; }

        public int WashSetTime { get; set; }

        public int alreadyTime { get; set; }

        public bool IsAlarm { get; set; }

        public bool IsReady { get; set; }

        public string EquipState { get; set; }= "未知/未启动";

        public bool  IsPumpRun { get; set; }
        public void EquipmentState(bool[] data)
        {
            if(data[5])
            {
                EquipState = "报警中";
            }
            else
            {
                if (data[0])
                {
                    EquipState = "待机中";
                }
                else if (data[1])
                {
                    EquipState = "启动中";
                }
                else if (data[2])
                {
                    EquipState = "清洗中";
                }
                else if (data[3])
                {
                    EquipState = "暂停中";
                }
                else if (data[4])
                {
                    EquipState = "清洗完成";
                }
                else
                {
                    EquipState = "未知/未启动";
                }
            }
           

        }

    }
}
