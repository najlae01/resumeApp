namespace resumeApp
{
    partial class libraries
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.butCoverLetters = new System.Windows.Forms.Button();
            this.butResumes = new System.Windows.Forms.Button();
            this.butCvs = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.panelMenu.Controls.Add(this.butCoverLetters);
            this.panelMenu.Controls.Add(this.butResumes);
            this.panelMenu.Controls.Add(this.butCvs);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(261, 611);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // butCoverLetters
            // 
            this.butCoverLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.butCoverLetters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.butCoverLetters.FlatAppearance.BorderSize = 0;
            this.butCoverLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCoverLetters.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butCoverLetters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butCoverLetters.Image = global::resumeApp.Properties.Resources.icons8_letter_48;
            this.butCoverLetters.Location = new System.Drawing.Point(0, 210);
            this.butCoverLetters.Name = "butCoverLetters";
            this.butCoverLetters.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.butCoverLetters.Size = new System.Drawing.Size(261, 65);
            this.butCoverLetters.TabIndex = 2;
            this.butCoverLetters.Text = "Cover Letters";
            this.butCoverLetters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butCoverLetters.UseVisualStyleBackColor = true;
            this.butCoverLetters.Click += new System.EventHandler(this.button3_Click);
            // 
            // butResumes
            // 
            this.butResumes.Dock = System.Windows.Forms.DockStyle.Top;
            this.butResumes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.butResumes.FlatAppearance.BorderSize = 0;
            this.butResumes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butResumes.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butResumes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butResumes.Image = global::resumeApp.Properties.Resources.icons8_resume_48;
            this.butResumes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butResumes.Location = new System.Drawing.Point(0, 145);
            this.butResumes.Name = "butResumes";
            this.butResumes.Padding = new System.Windows.Forms.Padding(16, 3, 0, 3);
            this.butResumes.Size = new System.Drawing.Size(261, 65);
            this.butResumes.TabIndex = 1;
            this.butResumes.Text = " Resumes";
            this.butResumes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butResumes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butResumes.UseVisualStyleBackColor = true;
            this.butResumes.Click += new System.EventHandler(this.button2_Click);
            // 
            // butCvs
            // 
            this.butCvs.Dock = System.Windows.Forms.DockStyle.Top;
            this.butCvs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.butCvs.FlatAppearance.BorderSize = 0;
            this.butCvs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCvs.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butCvs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butCvs.Image = global::resumeApp.Properties.Resources.icons8_cv_48;
            this.butCvs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCvs.Location = new System.Drawing.Point(0, 80);
            this.butCvs.Name = "butCvs";
            this.butCvs.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.butCvs.Size = new System.Drawing.Size(261, 65);
            this.butCvs.TabIndex = 0;
            this.butCvs.Text = " CVs";
            this.butCvs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCvs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butCvs.UseVisualStyleBackColor = true;
            this.butCvs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(261, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 125);
            this.panel1.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(81)))), ((int)(((byte)(45)))));
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(261, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(788, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.AutoSize = true;
            this.labelTitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitleBar.Font = new System.Drawing.Font("Lucida Console", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitleBar.Location = new System.Drawing.Point(333, 20);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.labelTitleBar.Size = new System.Drawing.Size(99, 37);
            this.labelTitleBar.TabIndex = 0;
            this.labelTitleBar.Text = "Home";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleBar.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImage = global::resumeApp.Properties.Resources.backg;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(261, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 531);
            this.panel2.TabIndex = 2;
            // 
            // libraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "libraries";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panel1;
        private Button butCvs;
        private Button butCoverLetters;
        private Button butResumes;
        private Panel panelTitleBar;
        private Label labelTitleBar;
        private Panel panel2;
    }
}