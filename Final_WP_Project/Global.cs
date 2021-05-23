using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_WP_Project
{
    class Global
    {
       public static string GlobalId { get; private set; }
        public static int Mana { get; private set; }
        public static int Recep { get; private set; }
        public static int Labor { get; private set; }
        public static void SetID(string userid)
        {
            GlobalId = userid;
        }
        public static void SetMana(int Manaa)
        {
            Mana = Manaa;
        }
        public static void SetRecep(int Recepp)
        {
            Recep = Recepp;
        }
        public static void SetLabor(int Laborr)
        {
            Labor = Laborr;
        }

    }
}
