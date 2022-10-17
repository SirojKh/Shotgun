using Shotgun.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Shotgun : Form
    {
        public Shotgun()
        {
            InitializeComponent();
        }


        Player player = new Player();
        Game game = new Game();
        Computer computer = new Computer();


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            game.cpuShell = 0;
            game.playerShell = 0;
            cpuShellScore.Text = game.cpuShell.ToString();
            playerShellScore.Text = game.playerShell.ToString();

            listBox2.Items.Clear();
            listBox1.Items.Clear();

            player.Shoot = "";
            player.Reload = "";
            player.Block = "";
            player.Shotgun = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click_1(object sender, EventArgs e)
        {
            player.Shoot = "Skjuta";
            listBox2.Items.Clear();
            listBox2.Items.Add(computer.getComputerChoise(game).ToString());
            listBox1.Items.Clear();
            listBox1.Items.Add(player.Shoot.ToString());

            game.checkGame(player, computer);

            cpuShellScore.Text = game.cpuShell.ToString();
            playerShellScore.Text = game.playerShell.ToString();
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            player.Reload = "Ladda";

            listBox2.Items.Clear();
            listBox2.Items.Add(player.Reload.ToString());
            listBox1.Items.Clear();
            listBox1.Items.Add(computer.getComputerChoise(game).ToString());

            game.checkGame(player, computer);

            cpuShellScore.Text = game.cpuShell.ToString();
            playerShellScore.Text = game.playerShell.ToString();
        }

        private void btnBlock_Click_1(object sender, EventArgs e)
        {
            player.Block = "Blocka";

            listBox2.Items.Clear();
            listBox2.Items.Add(player.Block.ToString());
            listBox2.Items.Clear();
            listBox2.Items.Add(computer.getComputerChoise(game).ToString());
            game.checkGame(player, computer);

            cpuShellScore.Text = game.cpuShell.ToString();
            playerShellScore.Text = game.playerShell.ToString();
        }

        private void btnShotgun_Click_1(object sender, EventArgs e)
        {
            player.Shotgun = "Shotgun";

            listBox2.Items.Clear();
            listBox2.Items.Add(player.Shotgun.ToString());

            game.checkGame(player, computer);

            cpuShellScore.Text = game.cpuShell.ToString();
            playerShellScore.Text = game.playerShell.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.cpuShell = 0;
            game.playerShell = 0;
            cpuShellScore.Text = game.cpuShell.ToString();
            playerShellScore.Text = game.playerShell.ToString();

            listBox2.Items.Clear();
            listBox1.Items.Clear();

            player.Shoot = "";
            player.Reload = "";
            player.Block = "";
            player.Shotgun = "";
        }
    }
}
