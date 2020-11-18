using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPressWash
{
    public class User 
    {

        public int id { get; set; }

        public string operator_name { get; set; }
        public int operator_num { get; set; }

        public string password { get; set; }

        public string telephone { get; set; }

        public DateTime register_date { get; set; }

        public DateTime dimission_date { get; set; }

        public string job { get; set; }

    }

    public enum Authority
    {
        Operator = 1,
        Maintainer = 2,
        Admin = 3,
    }
}
