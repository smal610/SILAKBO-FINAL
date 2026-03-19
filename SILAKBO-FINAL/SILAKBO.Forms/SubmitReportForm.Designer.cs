namespace SILAKBO_FINAL.SILAKBO.Forms
{
    partial class SubmitReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitReportForm));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnBrowseEvidence = new Button();
            btnSubmit = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(368, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 29);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(154, 153);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 1;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(154, 200);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 2;
            label2.Text = "Type of Harassment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(154, 247);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 3;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(154, 433);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 4;
            label4.Text = "Evidence (Optional):";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(367, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 29);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(368, 244);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 170);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(368, 430);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(334, 29);
            textBox3.TabIndex = 7;
            // 
            // btnBrowseEvidence
            // 
            btnBrowseEvidence.Font = new Font("Segoe UI", 12F);
            btnBrowseEvidence.Location = new Point(708, 429);
            btnBrowseEvidence.Name = "btnBrowseEvidence";
            btnBrowseEvidence.Size = new Size(93, 29);
            btnBrowseEvidence.TabIndex = 8;
            btnBrowseEvidence.Text = "Browse";
            btnBrowseEvidence.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(368, 479);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(433, 44);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 84);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 11;
            label5.Text = "Submit Report";
            // 
            // SubmitReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 591);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowseEvidence);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SubmitReportForm";
            Text = "Submit Report";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnBrowseEvidence;
        private Button btnSubmit;
        private PictureBox pictureBox1;
        private Label label5;
    }
}