namespace MoneyTask
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Xırdala_btn = new Button();
            Textbox_manat = new MaskedTextBox();
            label1 = new Label();
            panel2 = new Panel();
            pic_500_manat = new PictureBox();
            pic_100_manat = new PictureBox();
            pic_10_manat = new PictureBox();
            pic_50_manat = new PictureBox();
            pic_5_manat = new PictureBox();
            pic_20_manat = new PictureBox();
            pic_200_manat = new PictureBox();
            pic_1_manat = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_500_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_100_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_10_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_50_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_5_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_20_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_200_manat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_1_manat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(Xırdala_btn);
            panel1.Controls.Add(Textbox_manat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 707);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Xırdala_btn
            // 
            Xırdala_btn.Location = new Point(57, 354);
            Xırdala_btn.Name = "Xırdala_btn";
            Xırdala_btn.Size = new Size(232, 58);
            Xırdala_btn.TabIndex = 2;
            Xırdala_btn.Text = "Xırdala";
            Xırdala_btn.UseVisualStyleBackColor = true;
            Xırdala_btn.Click += Xırdala_btn_Click;
            // 
            // Textbox_manat
            // 
            Textbox_manat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox_manat.Location = new Point(57, 274);
            Textbox_manat.Mask = "00000";
            Textbox_manat.Name = "Textbox_manat";
            Textbox_manat.Size = new Size(232, 37);
            Textbox_manat.TabIndex = 1;
            Textbox_manat.ValidatingType = typeof(int);
            Textbox_manat.MaskInputRejected += Textbox_manat_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 220);
            label1.Name = "label1";
            label1.Size = new Size(232, 30);
            label1.TabIndex = 0;
            label1.Text = "Xırdalanacaq məbləğ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pic_500_manat);
            panel2.Controls.Add(pic_100_manat);
            panel2.Controls.Add(pic_10_manat);
            panel2.Controls.Add(pic_50_manat);
            panel2.Controls.Add(pic_5_manat);
            panel2.Controls.Add(pic_20_manat);
            panel2.Controls.Add(pic_200_manat);
            panel2.Controls.Add(pic_1_manat);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(480, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 707);
            panel2.TabIndex = 1;
            // 
            // pic_500_manat
            // 
            pic_500_manat.Image = (Image)resources.GetObject("pic_500_manat.Image");
            pic_500_manat.Location = new Point(433, 563);
            pic_500_manat.Name = "pic_500_manat";
            pic_500_manat.Size = new Size(230, 117);
            pic_500_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_500_manat.TabIndex = 9;
            pic_500_manat.TabStop = false;
            pic_500_manat.Click += pic_500_manat_Click;
            // 
            // pic_100_manat
            // 
            pic_100_manat.Image = (Image)resources.GetObject("pic_100_manat.Image");
            pic_100_manat.Location = new Point(433, 208);
            pic_100_manat.Name = "pic_100_manat";
            pic_100_manat.Size = new Size(230, 117);
            pic_100_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_100_manat.TabIndex = 8;
            pic_100_manat.TabStop = false;
            pic_100_manat.Click += pic_100_manat_Click;
            // 
            // pic_10_manat
            // 
            pic_10_manat.Image = (Image)resources.GetObject("pic_10_manat.Image");
            pic_10_manat.Location = new Point(81, 391);
            pic_10_manat.Name = "pic_10_manat";
            pic_10_manat.Size = new Size(230, 117);
            pic_10_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_10_manat.TabIndex = 6;
            pic_10_manat.TabStop = false;
            pic_10_manat.Click += pic_10_manat_Click;
            // 
            // pic_50_manat
            // 
            pic_50_manat.Image = (Image)resources.GetObject("pic_50_manat.Image");
            pic_50_manat.Location = new Point(433, 34);
            pic_50_manat.Name = "pic_50_manat";
            pic_50_manat.Size = new Size(230, 117);
            pic_50_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_50_manat.TabIndex = 5;
            pic_50_manat.TabStop = false;
            pic_50_manat.Click += pic_50_manat_Click;
            // 
            // pic_5_manat
            // 
            pic_5_manat.Image = (Image)resources.GetObject("pic_5_manat.Image");
            pic_5_manat.Location = new Point(81, 208);
            pic_5_manat.Name = "pic_5_manat";
            pic_5_manat.Size = new Size(230, 117);
            pic_5_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_5_manat.TabIndex = 3;
            pic_5_manat.TabStop = false;
            pic_5_manat.Click += pic_5_manat_Click;
            // 
            // pic_20_manat
            // 
            pic_20_manat.Image = (Image)resources.GetObject("pic_20_manat.Image");
            pic_20_manat.Location = new Point(81, 563);
            pic_20_manat.Name = "pic_20_manat";
            pic_20_manat.Size = new Size(230, 117);
            pic_20_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_20_manat.TabIndex = 2;
            pic_20_manat.TabStop = false;
            pic_20_manat.Click += pic_20_manat_Click;
            // 
            // pic_200_manat
            // 
            pic_200_manat.Image = (Image)resources.GetObject("pic_200_manat.Image");
            pic_200_manat.Location = new Point(433, 391);
            pic_200_manat.Name = "pic_200_manat";
            pic_200_manat.Size = new Size(230, 117);
            pic_200_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_200_manat.TabIndex = 1;
            pic_200_manat.TabStop = false;
            pic_200_manat.Click += pic_200_manat_Click;
            // 
            // pic_1_manat
            // 
            pic_1_manat.Image = (Image)resources.GetObject("pic_1_manat.Image");
            pic_1_manat.Location = new Point(81, 34);
            pic_1_manat.Name = "pic_1_manat";
            pic_1_manat.Size = new Size(230, 117);
            pic_1_manat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_1_manat.TabIndex = 0;
            pic_1_manat.TabStop = false;
            pic_1_manat.Click += pic_1_manat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 254);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 440);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 606);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(669, 79);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(669, 254);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(669, 440);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 16;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(669, 606);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 17;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1268, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_500_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_100_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_10_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_50_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_5_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_20_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_200_manat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_1_manat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pic_100_manat;
        private PictureBox pic_10_manat;
        private PictureBox pic_50_manat;
        private PictureBox pic_5_manat;
        private PictureBox pic_20_manat;
        private PictureBox pic_200_manat;
        private PictureBox pic_1_manat;
        private Button Xırdala_btn;
        private MaskedTextBox Textbox_manat;
        private PictureBox pic_500_manat;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
