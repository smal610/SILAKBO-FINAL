namespace SILAKBO_FINAL.SILAKBO.Forms
{
    partial class UserDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboardForm));
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            btnMyProfile = new Button();
            btnSubmitReport = new Button();
            btnTrackCase = new Button();
            btnSupportResources = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(12, 76);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(74, 21);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // btnMyProfile
            // 
            btnMyProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMyProfile.Location = new Point(202, 150);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(272, 134);
            btnMyProfile.TabIndex = 2;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmitReport.Location = new Point(501, 150);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(272, 134);
            btnSubmitReport.TabIndex = 3;
            btnSubmitReport.Text = "Submit Report";
            btnSubmitReport.UseVisualStyleBackColor = true;
            // 
            // btnTrackCase
            // 
            btnTrackCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTrackCase.Location = new Point(202, 317);
            btnTrackCase.Name = "btnTrackCase";
            btnTrackCase.Size = new Size(272, 134);
            btnTrackCase.TabIndex = 4;
            btnTrackCase.Text = "Track Case";
            btnTrackCase.UseVisualStyleBackColor = true;
            // 
            // btnSupportResources
            // 
            btnSupportResources.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSupportResources.Location = new Point(501, 317);
            btnSupportResources.Name = "btnSupportResources";
            btnSupportResources.Size = new Size(272, 134);
            btnSupportResources.TabIndex = 5;
            btnSupportResources.Text = "Support Resources";
            btnSupportResources.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(877, 39);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 591);
            Controls.Add(btnLogout);
            Controls.Add(btnSupportResources);
            Controls.Add(btnTrackCase);
            Controls.Add(btnSubmitReport);
            Controls.Add(btnMyProfile);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox1);
            Name = "UserDashboardForm";
            Text = "User Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Button btnMyProfile;
        private Button btnSubmitReport;
        private Button btnTrackCase;
        private Button btnSupportResources;
        private Button btnLogout;
    }
}