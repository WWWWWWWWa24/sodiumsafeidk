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
    public partial class Sodium : Form
    {
        public Sodium()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string gettext = siticoneTextBox1.Text;
            int gettext_amount = gettext.Length;

            if (gettext_amount > 1)
            {
                WebClient clientt = new WebClient();
                    string key = clientt.DownloadString("https://raw.githubusercontent.com/keru6k/keru6x/main/keysys");
                if (key.Contains(siticoneTextBox1.Text))
                {
                    this.Hide();
                    LoaderUI loaderui = new LoaderUI();
                    loaderui.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Incorrect Key. Make sure to paste the key the admin has given you.", "keyAuthError");
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sodium_Load(object sender, EventArgs e)
        {

        }
    }
}
