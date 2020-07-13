using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{


    class Class1
    {
        public enum Types
        {
            Book,
            Movie,
            Electronics,
            BlockBuster


        }
       
        public string P_Name { get; set; }

        public Types P_type { get; set; }

        public int Price { get; set; }

        public  bool Sale { get; set; }

        public string Desc { get; set; }

        public Class1(string p_Name, Types p_type, int price, bool sale, string desc)
        {
            
            P_Name = p_Name;
            P_type = p_type;
            Price = price;
            Sale = sale;
            Desc = desc;
        }



        //public string PTeam { get; set; }


       


    }
}
