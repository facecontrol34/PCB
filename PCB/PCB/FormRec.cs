using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCB
{
    public partial class FormRec : Form
    {
        private bool isDragging = false;
        private Point lastCursorPosition;
        public FormRec()
        {
            InitializeComponent();
            LabelAttach(label1);
            LabelAttach(label2);
            LabelAttach(label3);
            LabelAttach(label4);
            LabelAttach(label5);
            LabelAttach(label6);
            LabelAttach(label7);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/rZspi4ohAWI?si=V-3xmlkPyh5MAx-Y");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/LMD93KxOkJg?si=J323-b997fD_wRqQ");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/MEBPOBjmSu4?si=q9iVAsBSR5NLGSU9");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/jSq5JtZMMas?si=5ZyHt68YVUk9XfIf");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/Qw73HrlADfg?si=x_RTJdA3svBJCVNQ");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/WZ8Hgpmsunc?si=FqIsV3euD3ZBYG1H");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/LlNcMxZ06uc?si=ng9xp9tJu8WO1iaE");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // дизайн
        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.RoyalBlue;
            buttonExit.ForeColor = Color.White;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.LightSteelBlue;
            buttonExit.ForeColor = Color.Black;
        }

        private void LabelAttach(Label label)
        {
            label.MouseEnter += Button_MouseEnter;
            label.MouseLeave += Button_MouseLeave;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control lb = sender as Control;
            // Изменение цвета фона при наведении мыши
            lb.ForeColor = Color.White;
            lb.Font = new Font(lb.Font, FontStyle.Regular);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control lb = sender as Control;
            // Возвращение исходного цвета фона при уходе мыши
            lb.ForeColor = Color.Black;
            lb.Font = new Font(lb.Font, FontStyle.Underline);
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = Cursor.Position;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursorPosition = Cursor.Position;
                int deltaX = currentCursorPosition.X - lastCursorPosition.X;
                int deltaY = currentCursorPosition.Y - lastCursorPosition.Y;
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
                lastCursorPosition = currentCursorPosition;
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
