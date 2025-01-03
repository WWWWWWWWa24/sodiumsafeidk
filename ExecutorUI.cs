// open source #omegalul

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;
using DiscordRpcDemo;

namespace SodiumV1
{
    public partial class ExecutorUI : Form
    {

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        EasyExploits.Module kiri = new EasyExploits.Module();
        
        public ExecutorUI()
        {
            InitializeComponent();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            kiri.LaunchExploit();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            kiri.ExecuteScript(this.fastColoredTextBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }
        private void siticoneImageButton3_Click(object sender, EventArgs e)
        {
            settingsTab settings1 = new settingsTab();
            settings1.Show();
            settings1.SetDesktopLocation(this.Location.X + -65, this.Location.Y);
        }
        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            ExecutorUI ex1 = new ExecutorUI();
            ex1.ShowDialog();
            this.Close();
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations! you've found this secret dialog!", ";D");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Hide();
            }
            Opacity -= .025;
        }

        private void siticoneImageButton4_Click(object sender, EventArgs e)
        {
            aboutSection about = new aboutSection();
            about.Show();
            about.SetDesktopLocation(this.Location.X + -65, this.Location.Y);
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox2.Clear();
        }

        private void fastColoredTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            kiri.killRoblox();
        }

        private void ExecutorUI_Load(object sender, EventArgs e)
        {

        }
    }
}
