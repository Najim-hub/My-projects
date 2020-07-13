using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Class2
    {
        public string U_Name { get; set; }
        public string O_Name { get; set; }

        public Class1.Types O_type { get; set; }

        public int Total_Price { get; set; }

        public bool Sale { get; set; }

        public string New_Desc { get; set; }

        public Class2(string u_Name, string o_Name, Class1.Types o_type, int total_Price, bool sale, string new_Desc)
        {
            U_Name = u_Name;
            O_Name = o_Name;
            O_type = o_type;
            Total_Price = total_Price;
            Sale = sale;
            New_Desc = new_Desc;
        }

       
    }
}
