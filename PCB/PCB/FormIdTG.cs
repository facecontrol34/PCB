using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PCBuilder
{
    public partial class FormIdTG : Form
    {
        string mstg = "";

        public FormIdTG(string message)
        {
            mstg = message;
            InitializeComponent();
        }
        async Task tgMessageAsync(string messag, string chat)
        {
            string botToken = "7043541329:AAFUqN4E2r5Kxln1OiGZOJQb4IW2IXBVWx4"; // pcb bot 7043541329:AAFUqN4E2r5Kxln1OiGZOJQb4IW2IXBVWx4
            string chatId = chat;
            string message = messag;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"https://api.telegram.org/bot{botToken}/sendMessage?chat_id={chatId}&text={message}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ошибка при отправке сообщения в Telegram.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Сообщение успешно отправлено в Telegram.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //response.EnsureSuccessStatusCode();
            }
        }
       

        private void TGMessageButton_Click(object sender, EventArgs e)
        {
            string chat = IDChatTextBox.Text;
            tgMessageAsync(mstg, chat);
            this.Close();
        }

        private void botLabel_Click(object sender, EventArgs e)
        {
            // Открыть ссылку в браузере по умолчанию
            System.Diagnostics.Process.Start("https://t.me/LeadConverterToolkitBot");
        }

        // дизайн
        private void TGMessageButton_MouseEnter(object sender, EventArgs e)
        {
            TGMessageButton.BackColor = Color.RoyalBlue;
            TGMessageButton.ForeColor = Color.White;
        }

        private void TGMessageButton_MouseLeave(object sender, EventArgs e)
        {
            TGMessageButton.BackColor = Color.LightSteelBlue;
            TGMessageButton.ForeColor = Color.Black;
        }
        private void IDChatTextBox_MouseEnter(object sender, EventArgs e)
        {
            IDChatTextBox.BackColor = Color.RoyalBlue;
            IDChatTextBox.ForeColor = Color.White;
        }

        private void IDChatTextBox_MouseLeave(object sender, EventArgs e)
        {
            IDChatTextBox.BackColor = Color.LightSteelBlue;
            IDChatTextBox.ForeColor = Color.Black;
        }

        private void botLabel_MouseEnter(object sender, EventArgs e)
        {
            botLabel.ForeColor = Color.Purple;
            botLabel.Font = new Font(botLabel.Font, FontStyle.Regular);
        }

        private void botLabel_MouseLeave(object sender, EventArgs e)
        {
            botLabel.ForeColor = Color.Crimson;
            botLabel.Font = new Font(botLabel.Font, FontStyle.Underline);
        }
    }
}
