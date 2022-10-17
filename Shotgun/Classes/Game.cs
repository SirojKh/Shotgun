using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    internal class Game
    {
        public int cpuShell { get; set; }
        public int playerShell { get; set; }

        public Game()
        {
        }
        public void checkGame(Player player, Computer computer)
        {
            if (player.Shoot == "Skjuta" && computer.computerChoise == "Ladda")
            {
                if (playerShell == 0)
                {
                    MessageBox.Show("Du behöver ladda först");
                    player.Shoot = "";
                }
                else
                {
                    MessageBox.Show("Player Vann!");
                    playerShell = 0;
                    cpuShell = 0;
                    player.Shoot = "";
                }
            }
            else if (player.Shoot == "Skjuta" && computer.computerChoise == "Skjuta")
            {
                playerShell -= 1;
                cpuShell -= 1;
                bool a = playerShell != -1;
                bool b = cpuShell != -1;

                player.Shoot = "";
            }
            else if (player.Shoot == "Skjuta" && computer.computerChoise == "Blocka")
            {
                if (playerShell == 0)
                {
                    MessageBox.Show("Du behöver ladda först");
                    player.Shoot = "";
                }
                else
                {
                    playerShell -= 1;
                    player.Shoot = "";
                }
            }

            else if (player.Reload == "Ladda" && computer.computerChoise == "Blocka")
            {
                playerShell += 1;
                player.Reload = "";
            }
            else if (player.Reload == "Ladda" && computer.computerChoise == "Ladda")
            {
                playerShell += 1;
                cpuShell += 1;
                player.Reload = "";
            }
            else if (player.Reload == "Ladda" && computer.computerChoise == "Skjuta")
            {
                MessageBox.Show("Computer Vann");
                playerShell = 0;
                cpuShell = 0;
            }
            else if (player.Block == "Blocka" && computer.computerChoise == "Blocka")
            {
                player.Block = "";
            }
            else if (player.Block == "Blocka" && computer.computerChoise == "Skjuta")
            {
                cpuShell -= 1;
                player.Block = "";
            }
            else if (player.Block == "Blocka" && computer.computerChoise == "Ladda")
            {
                cpuShell += 1;
                player.Block = "";
            }
            else if (player.Shotgun == "Shotgun")
            {
                if (playerShell == 3)
                {
                    MessageBox.Show("SHOTGUN, Player Vann");
                    playerShell = 0;
                    cpuShell = 0;
                    player.Shotgun = "";
                }
                else
                {
                    MessageBox.Show("Du behöver ladda 3 skott");
                    player.Shotgun = "";
                }
            }
            else if (computer.computerChoise == "Shotgun")
            {
                MessageBox.Show("SHOTGUN, Computer Vann");
                playerShell = 0;
                cpuShell = 0;
            }
        }

    }
}
