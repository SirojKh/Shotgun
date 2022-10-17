using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    internal class Computer
    {
        public string computerChoise { get; set; }
        //Random random = new Random();

        public Computer()
        {
        }

        public string getComputerChoise(Game game)
        {
            Random rnd = new Random();

            if (game.playerShell == 3)
            {
                computerChoise = "Shotgun";
                return computerChoise;
            }
            else if (game.playerShell > 0)
            {
                string[] cpuChoiseList = { "Skjuta", "Ladda", "Blocka", "Skjuta", "Ladda", "Blocka" };
                int i = rnd.Next(0, cpuChoiseList.Length);
                computerChoise = cpuChoiseList[i];
                return computerChoise;
            }
            else
            {
                string[] cpuChoiseList = { "Blocka", "Ladda", "Blocka", "Ladda" };
                int i = rnd.Next(0, cpuChoiseList.Length);
                computerChoise = cpuChoiseList[i];
                return computerChoise;
            }
        }

    }
}
