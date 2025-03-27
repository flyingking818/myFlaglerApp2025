namespace myFlaglerApp2025
{
    partial class ProfileDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBasicInfo = new System.Windows.Forms.TabPage();
            this.tpAcademics = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpBasicInfo.SuspendLayout();
            this.tpAcademics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(941, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Detail";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBasicInfo);
            this.tabControl1.Controls.Add(this.tpAcademics);
            this.tabControl1.Location = new System.Drawing.Point(89, 187);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1886, 830);
            this.tabControl1.TabIndex = 1;
            // 
            // tpBasicInfo
            // 
            this.tpBasicInfo.BackColor = System.Drawing.Color.RosyBrown;
            this.tpBasicInfo.Controls.Add(this.textBox1);
            this.tpBasicInfo.Location = new System.Drawing.Point(8, 39);
            this.tpBasicInfo.Name = "tpBasicInfo";
            this.tpBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasicInfo.Size = new System.Drawing.Size(1870, 783);
            this.tpBasicInfo.TabIndex = 0;
            this.tpBasicInfo.Text = "Basic Information";
            // 
            // tpAcademics
            // 
            this.tpAcademics.BackColor = System.Drawing.Color.DarkOrange;
            this.tpAcademics.Controls.Add(this.button1);
            this.tpAcademics.Location = new System.Drawing.Point(8, 39);
            this.tpAcademics.Name = "tpAcademics";
            this.tpAcademics.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcademics.Size = new System.Drawing.Size(1870, 783);
            this.tpAcademics.TabIndex = 1;
            this.tpAcademics.Text = "Academics";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfileDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2058, 1086);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "ProfileDetailForm";
            this.Text = "ProfileDetailForm";
            this.tabControl1.ResumeLayout(false);
            this.tpBasicInfo.ResumeLayout(false);
            this.tpBasicInfo.PerformLayout();
            this.tpAcademics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBasicInfo;
        private System.Windows.Forms.TabPage tpAcademics;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}