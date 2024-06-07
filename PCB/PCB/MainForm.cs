using PCB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PCBuilder
{
    public partial class MainForm : Form
    {
        string email = "";
        public MainForm(string email)
        {
            InitializeComponent();
            ButtonAttach(New_build_button);
            ButtonAttach(Sample_button);
            ButtonAttach(recButton);
            this.email = email;
        }

        private void MaimForm_Load(object sender, EventArgs e)
        {

        }

        private void New_build_button_Click(object sender, EventArgs e)
        {
            newBuildPc form1 = new newBuildPc(email);
            form1.ShowDialog();
        }

        private void Sample_button_Click(object sender, EventArgs e)
        {
            ShablonForm form = new ShablonForm(email);
            form.ShowDialog();
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            FormRec formRec = new FormRec();
            formRec.ShowDialog();
        }

        private void tgBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/pcbuilder58");
        }

        private void ThisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Закрыть все приложение
                Application.Exit();
            }
        }

        // дизайн
        private void tgBox_MouseEnter(object sender, EventArgs e)
        {
            tgBox.Image = PCB.Properties.Resources.tgblueicon;
            tgBox.BackgroundImageLayout = ImageLayout.Stretch;
            tgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tgBox_MouseLeave(object sender, EventArgs e)
        {
            tgBox.Image = PCB.Properties.Resources.png_clipart_computer_icons_scalable_graphics_blue_youtube_icon_ico_computer_icons_telegram;
            tgBox.BackgroundImageLayout = ImageLayout.Stretch;
            tgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ButtonAttach(Button bt)
        {
            bt.MouseEnter += Button_MouseEnter;
            bt.MouseLeave += Button_MouseLeave;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            // Изменение цвета фона при наведении мыши
            bt.BackColor = Color.RoyalBlue;
            bt.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            // Возвращение исходного цвета фона при уходе мыши
            bt.BackColor = Color.LightSteelBlue;
            bt.ForeColor = Color.Black;
        }
    }
}
