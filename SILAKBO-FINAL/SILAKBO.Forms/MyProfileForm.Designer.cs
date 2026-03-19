namespace SILAKBO_FINAL.SILAKBO.Forms
{
    partial class MyProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfileForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClose = new Button();
            pBLogo = new PictureBox();
            lblName = new Label();
            lblUsername = new Label();
            lblGender = new Label();
            lblBirthday = new Label();
            lblRole = new Label();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(545, 219);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(545, 266);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(545, 319);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 3;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(545, 370);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 4;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(545, 419);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 5;
            label5.Text = "Role:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(683, 480);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(83, 28);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pBLogo
            // 
            pBLogo.BackColor = Color.Transparent;
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(468, 77);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(455, 101);
            pBLogo.TabIndex = 11;
            pBLogo.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(683, 219);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 21);
            lblName.TabIndex = 12;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(683, 266);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 21);
            lblUsername.TabIndex = 13;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(683, 319);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 21);
            lblGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.BackColor = Color.Transparent;
            lblBirthday.Font = new Font("Segoe UI", 12F);
            lblBirthday.Location = new Point(683, 370);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(0, 21);
            lblBirthday.TabIndex = 15;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 12F);
            lblRole.Location = new Point(683, 419);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 21);
            lblRole.TabIndex = 16;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 591);
            Controls.Add(lblRole);
            Controls.Add(lblBirthday);
            Controls.Add(lblGender);
            Controls.Add(lblUsername);
            Controls.Add(lblName);
            Controls.Add(pBLogo);
            Controls.Add(btnClose);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MyProfileForm";
            Text = "MyProfileForm";
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClose;
        private TextBox txtUsername;
        private TextBox txtGender;
        private TextBox txtBirthday;
        private TextBox txtRole;
        private PictureBox pBLogo;
        private Label lblName;
        private Label lblUsername;
        private Label lblGender;
        private Label lblBirthday;
        private Label lblRole;
    }
}