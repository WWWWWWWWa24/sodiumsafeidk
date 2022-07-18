
namespace SodiumV1
{
    partial class LoaderUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.siticoneButton2);
            this.panel1.Location = new System.Drawing.Point(-10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 20);
            this.panel1.TabIndex = 6;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(452, 3);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedColor = System.Drawing.Color.Empty;
            this.siticoneButton2.PressedDepth = 0;
            this.siticoneButton2.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.siticoneButton2.ShadowDecoration.Depth = 0;
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(22, 14);
            this.siticoneButton2.TabIndex = 6;
            this.siticoneButton2.Text = "X";
            this.siticoneButton2.Visible = false;
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 24);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel3.Location = new System.Drawing.Point(12, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 24);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Checking Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(469, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaderUI";
            this.Load += new System.EventHandler(this.LoaderUI_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}