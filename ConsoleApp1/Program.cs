using menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyApplication = new ApplicationFruits();
            string UserInput = MyApplication.DisplayActions();
            while(UserInput == "1" || UserInput == "2")
            {
                UserInput = MyApplication.DisplayActions();
                MyApplication.ApplicationStarter(UserInput);
            }

            if(UserInput == "3")
            {
                MyApplication.ApplicationStarter(UserInput);

            }

        }
    }
}
