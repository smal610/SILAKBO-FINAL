namespace SILAKBO_FINAL.SILAKBO.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pBLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            comboGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            SuspendLayout();
            // 
            // pBLogo
            // 
            pBLogo.BackColor = Color.Transparent;
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(470, 58);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(455, 101);
            pBLogo.TabIndex = 1;
            pBLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(470, 211);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(470, 259);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(470, 307);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(470, 367);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 5;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(470, 416);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 6;
            label5.Text = "Birthday:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(582, 203);
            txtName.Name = "txtName";
            txtName.Size = new Size(343, 29);
            txtName.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(582, 251);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(343, 29);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(582, 299);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(343, 29);
            txtPassword.TabIndex = 9;
            // 
            // comboGender
            // 
            comboGender.Font = new Font("Segoe UI", 12F);
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Female" });
            comboGender.Location = new Point(582, 359);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(343, 29);
            comboGender.TabIndex = 10;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Segoe UI", 12F);
            dtpBirthday.Location = new Point(582, 408);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(343, 29);
            dtpBirthday.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Indigo;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(707, 488);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(218, 49);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleVioletRed;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(470, 488);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(218, 49);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(817, 334);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 14;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(470, 470);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 15;
            label6.Text = "Already have an account?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 591);
            Controls.Add(label6);
            Controls.Add(chkShowPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(dtpBirthday);
            Controls.Add(comboGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pBLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "Register New Account";
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox comboGender;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Label label6;
    }
}