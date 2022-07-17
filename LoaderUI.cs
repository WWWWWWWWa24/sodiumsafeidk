using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SodiumV1
{
    public partial class LoaderUI : Form
    {
        public LoaderUI()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            await Task.Delay(1500);
            WebClient UpdateCheck = new WebClient();
            panel3.Width = 120;
            label1.Text = ("Checking for Updates..");
            await Task.Delay(2500);
            if (!UpdateCheck.DownloadString("https://raw.githubusercontent.com/keru6k/keru6x/main/UpdateChecker").Contains("1.0512")) 
            {
                label1.Text = ("Outdated Version Detected");
                MessageBox.Show("You're Using an Outdated Version of Sodium. Please update to the latest version.", "updateError");
                await Task.Delay(1500);
                Application.Exit();
            }
            else
            {
                panel3.Width = 240;
                label1.Text = ("Checking Patch..");
                await Task.Delay(1500);
                WebClient patchCheck = new WebClient();
                if (!patchCheck.DownloadString("https://raw.githubusercontent.com/keru6k/keru6x/main/Patch").Contains("notpatched"))
                {
                    MessageBox.Show("Sodium is currently being patched. Please wait for a few hours. Else, Contact Keru6k", "patchError");
                    await Task.Delay(1500);
                    Application.Exit();
                }
                else
                {
                    panel3.Width = 340;
                    label1.Text = ("Loading...");
                    await Task.Delay(1500);
                    panel3.Width = 445;
                    await Task.Delay(1000);
                    this.Hide();
                    ExecutorUI executr = new ExecutorUI();
                    executr.ShowDialog();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoaderUI_Load(object sender, EventArgs e)
        {

        }
    }
}
