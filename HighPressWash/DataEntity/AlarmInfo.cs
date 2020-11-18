using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class AlarmInfo 
    {
       
        public DateTime BeginTime { get; set; }
       
        public DateTime? EndTime { get; set; }
           
        public string Description { get; set; }
      
        public string TriggerValue { get; set; }
      
    }
}
