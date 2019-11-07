using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using static System.Console;

namespace Thursday11._07._19
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** Fun with config Files ****\n");

            string[] appSetting = new string[5];
            appSetting[0] = ConfigurationManager.AppSettings["provider1"];
            appSetting[1] = ConfigurationManager.AppSettings["provider2"];
            appSetting[2] = ConfigurationManager.AppSettings["connectionString2"];
            appSetting[3] = ConfigurationManager.AppSettings["provider3"];
            appSetting[4] = ConfigurationManager.AppSettings["connectionString3"];

            foreach(string s in appSetting)
            {
                WriteLine(s);
            }

            WriteLine(ConfigurationManager.ConnectionStrings["AutoLotOLdeDbProvider"].ConnectionString);
        }
    }
}
