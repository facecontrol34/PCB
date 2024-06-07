using PCBuilder;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing;

namespace PCB
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        public string GetUserEmail(string login)
        {
            DB db = new DB();
            string query = "SELECT Email FROM Users WHERE Login = @login";

            using (SqlConnection connection = db.getConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        throw new ArgumentException("User with this login does not exist.");
                    }
                }
            }
        }

        private async void AuthorizationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            string hashedPassword = PasswordHasher.HashPassword(password);

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Login = @login", db.getConnection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                // Получаем хэш пароля из базы данных
                string storedHash = table.Rows[0]["Password"].ToString();

                // Сравниваем хэши паролей
                if (storedHash == hashedPassword)
                {
                    string email = GetUserEmail(LoginTextBox.Text); ;
                    MessageBox.Show("Вход выполнен успешно!");
                    MainForm form1 = new MainForm(email);
                    this.Hide();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль!");
                }
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль!");
            }
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            this.Hide();
            form.ShowDialog();
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
        private void AuthorizationButton_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationButton.BackColor = Color.RoyalBlue;
            AuthorizationButton.ForeColor = Color.White;
        }

        private void AuthorizationButton_MouseLeave(object sender, EventArgs e)
        {
            AuthorizationButton.BackColor = Color.LightSteelBlue;
            AuthorizationButton.ForeColor = Color.Black;
        }

        private void RegistrationLabel_MouseEnter(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.White;
            RegistrationLabel.Font = new Font(RegistrationLabel.Font, FontStyle.Regular);
        }

        private void RegistrationLabel_MouseLeave(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.Black;
            RegistrationLabel.Font = new Font(RegistrationLabel.Font, FontStyle.Underline);
        }

        private void LoginTextBox_MouseEnter(object sender, EventArgs e)
        {
            LoginTextBox.BackColor = Color.RoyalBlue;
            LoginTextBox.ForeColor = Color.White;
        }

        private void LoginTextBox_MouseLeave(object sender, EventArgs e)
        {
            LoginTextBox.BackColor = Color.LightSteelBlue;
            LoginTextBox.ForeColor = Color.Black;
        }

        private void PasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.RoyalBlue;
            PasswordTextBox.ForeColor = Color.White;
        }

        private void PasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.LightSteelBlue;
            PasswordTextBox.ForeColor = Color.Black;
        }
    }

    // Класс для хэширования паролей
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Преобразуем пароль в массив байт
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Хэшируем пароль с помощью MD5
            byte[] hashBytes;
            using (MD5 md5 = MD5.Create())
            {
                hashBytes = md5.ComputeHash(passwordBytes);
            }

            // Преобразуем массив байт хэша в строку в формате HEX
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            string hashedPassword = sb.ToString();

            return hashedPassword;
        }
    }
}
