using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoneyTask
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider1;

        public Form1()
        {
            InitializeComponent();

            errorProvider1 = new ErrorProvider();
            ResetVisibilities();
        }

        private void ResetVisibilities()
        {
            pic_500_manat.Visible = false;
            pic_200_manat.Visible = false;
            pic_100_manat.Visible = false;
            pic_50_manat.Visible = false;
            pic_20_manat.Visible = false;
            pic_10_manat.Visible = false;
            pic_5_manat.Visible = false;
            pic_1_manat.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void Xırdala_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textbox_manat.Text) || Textbox_manat.Text == "00000" || Textbox_manat.Text.Replace(" ", "").Length == 0)
            {
                errorProvider1.SetError(Textbox_manat, "Məbləğ daxil edin");
                return;
            }
            else
            {
                errorProvider1.SetError(Textbox_manat, string.Empty);
            }

            if (!int.TryParse(Textbox_manat.Text, out int mebleg))
            {
                MessageBox.Show("Zəhmət olmasa düzgün rəqəm daxil edin!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mebleg <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResetVisibilities();

            int say_500 = mebleg / 500;
            mebleg %= 500;

            int say_200 = mebleg / 200;
            mebleg %= 200;

            int say_100 = mebleg / 100;
            mebleg %= 100;

            int say_50 = mebleg / 50;
            mebleg %= 50;

            int say_20 = mebleg / 20;
            mebleg %= 20;

            int say_10 = mebleg / 10;
            mebleg %= 10;

            int say_5 = mebleg / 5;
            mebleg %= 5;

            int say_1 = mebleg;

            if (say_500 > 0)
            {
                pic_500_manat.Visible = true;
                label9.Text = $"{say_500} ədəd";
                label9.Visible = true;
            }

            if (say_200 > 0)
            {
                pic_200_manat.Visible = true;
                label8.Text = $"{say_200} ədəd";
                label8.Visible = true;
            }

            if (say_100 > 0)
            {
                pic_100_manat.Visible = true;
                label7.Text = $"{say_100} ədəd";
                label7.Visible = true;
            }

            if (say_50 > 0)
            {
                pic_50_manat.Visible = true;
                label6.Text = $"{say_50} ədəd";
                label6.Visible = true;
            }

            if (say_20 > 0)
            {
                pic_20_manat.Visible = true;
                label5.Text = $"{say_20} ədəd";
                label5.Visible = true;
            }

            if (say_10 > 0)
            {
                pic_10_manat.Visible = true;
                label4.Text = $"{say_10} ədəd";
                label4.Visible = true;
            }

            if (say_5 > 0)
            {
                pic_5_manat.Visible = true;
                label3.Text = $"{say_5} ədəd";
                label3.Visible = true;
            }

            if (say_1 > 0)
            {
                pic_1_manat.Visible = true;
                label2.Text = $"{say_1} ədəd";
                label2.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pic_1_manat_Click(object sender, EventArgs e) { }
        private void pic_5_manat_Click(object sender, EventArgs e) { }
        private void pic_10_manat_Click(object sender, EventArgs e) { }
        private void pic_20_manat_Click(object sender, EventArgs e) { }
        private void pic_50_manat_Click(object sender, EventArgs e) { }
        private void pic_100_manat_Click(object sender, EventArgs e) { }
        private void pic_200_manat_Click(object sender, EventArgs e) { }
        private void pic_500_manat_Click(object sender, EventArgs e) { }

        private void Textbox_manat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(Textbox_manat, string.Empty);
        }
    }
}