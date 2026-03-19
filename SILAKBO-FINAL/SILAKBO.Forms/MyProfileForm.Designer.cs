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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClose = new Button();
            txtUsername = new TextBox();
            txtGender = new TextBox();
            txtBirthday = new TextBox();
            txtRole = new TextBox();
            pBLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(605, 212);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 29);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(497, 220);
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
            label2.Location = new Point(497, 267);
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
            label3.Location = new Point(497, 320);
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
            label4.Location = new Point(497, 371);
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
            label5.Location = new Point(497, 420);
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
            btnClose.Click += btnClose_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(605, 259);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(318, 29);
            txtUsername.TabIndex = 7;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 12F);
            txtGender.Location = new Point(605, 312);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(318, 29);
            txtGender.TabIndex = 8;
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("Segoe UI", 12F);
            txtBirthday.Location = new Point(605, 363);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(318, 29);
            txtBirthday.TabIndex = 9;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 12F);
            txtRole.Location = new Point(605, 412);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(318, 29);
            txtRole.TabIndex = 10;
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
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 591);
            Controls.Add(pBLogo);
            Controls.Add(txtRole);
            Controls.Add(txtBirthday);
            Controls.Add(txtGender);
            Controls.Add(txtUsername);
            Controls.Add(btnClose);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
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
    }
}