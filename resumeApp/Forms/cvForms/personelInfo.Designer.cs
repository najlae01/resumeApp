namespace resumeApp.Forms.cvForms
{
    partial class personelInfo
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
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.ForeColor = System.Drawing.Color.DarkGray;
            this.name.Location = new System.Drawing.Point(212, 84);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(505, 35);
            this.name.TabIndex = 0;
            this.name.Text = "e.g. James Smith";
            this.name.Click += new System.EventHandler(this.name_Click);
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.address.ForeColor = System.Drawing.Color.DarkGray;
            this.address.Location = new System.Drawing.Point(212, 167);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(505, 35);
            this.address.TabIndex = 4;
            this.address.Text = "e.g. Av 12 Rue 25 Paris";
            this.address.Click += new System.EventHandler(this.address_Click);
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email.ForeColor = System.Drawing.Color.DarkGray;
            this.email.Location = new System.Drawing.Point(212, 246);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(505, 35);
            this.email.TabIndex = 5;
            this.email.Text = "e.g. james.smith@gmail.com";
            this.email.Click += new System.EventHandler(this.email_Click);
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phone.ForeColor = System.Drawing.Color.DarkGray;
            this.phone.Location = new System.Drawing.Point(212, 333);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(505, 35);
            this.phone.TabIndex = 6;
            this.phone.Text = "e.g. 06 45 67 43 35";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.status.ForeColor = System.Drawing.Color.DarkGray;
            this.status.Location = new System.Drawing.Point(212, 415);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(505, 35);
            this.status.TabIndex = 7;
            this.status.Text = "e.g. Célibataire";
            this.status.Click += new System.EventHandler(this.status_Click);
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(81)))), ((int)(((byte)(45)))));
            this.nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(81)))), ((int)(((byte)(45)))));
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nextBtn.Location = new System.Drawing.Point(751, 461);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(139, 47);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "Suivant";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(47)))));
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(210, 42);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(120, 20);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Nom Complet*";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(47)))));
            this.addressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addressLabel.Location = new System.Drawing.Point(210, 125);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(75, 20);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Adresse*";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(47)))));
            this.emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(210, 205);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 20);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email*";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(47)))));
            this.phoneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneLabel.Location = new System.Drawing.Point(210, 290);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(94, 20);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Téléphone*";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(47)))));
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusLabel.Location = new System.Drawing.Point(210, 372);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(150, 20);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Situation Familiale*";
            // 
            // personelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(902, 538);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Name = "personelInfo";
            this.Text = "personelInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox name;
        private TextBox address;
        private TextBox email;
        private TextBox phone;
        private TextBox status;
        private Button nextBtn;
        private Label nameLabel;
        private Label addressLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label statusLabel;
    }
}