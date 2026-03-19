namespace SILAKBO_FINAL.SILAKBO.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            pictureBox1 = new PictureBox();
            btnRefresh = new Button();
            dgvReports = new DataGridView();
            btnUpdateStatus = new Button();
            comboStatus = new ComboBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(315, 99);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(12, 128);
            dgvReports.Name = "dgvReports";
            dgvReports.Size = new Size(940, 439);
            dgvReports.TabIndex = 3;
            dgvReports.SelectionChanged += dgvReports_SelectionChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(218, 99);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(91, 23);
            btnUpdateStatus.TabIndex = 6;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(12, 99);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(200, 23);
            comboStatus.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(877, 98);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 591);
            Controls.Add(btnLogout);
            Controls.Add(comboStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(pictureBox1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvReports);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnRefresh;
        private DataGridView dgvReports;
        private Button btnUpdateStatus;
        private ComboBox comboStatus;
        private Button btnLogout;
    }
}