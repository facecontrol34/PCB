using PCB;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PCBuilder
{
    public partial class RegistrationForm : Form
    {
        // Константы для адреса электронной почты отправителя и пароля
        private const string EmailFrom = "PCBuilder58@yandex.ru";
        private const string Password = "ofgljslytncnjmbj";
        Boolean checkLog = false;
        public RegistrationForm()
        {
            InitializeComponent();
        }



        // Метод для валидации данных перед регистрацией
        private bool ValidateRegistration()
        {
            string login = LoginTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            // Проверка заполнения всех полей
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return false;
            }

            // Проверка соответствия пароля требованиям
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов, " +
                                "включая цифры и не содержать пробелов.");
                return false;
            }

            // Проверка совпадения паролей
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return false;
            }

            // Проверка корректности введенного email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.");
                EmailTextBox.Clear(); // Очищаем поле email в случае некорректного ввода
                return false;
            }

            return true;
        }

        // Метод для валидации email
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Метод для валидации пароля
        private bool IsPasswordValid(string password)
        {
            var passwordPattern = new Regex(@"^(?=.*\d)(?=.*[^\s]).{8,}$");
            return passwordPattern.IsMatch(password);
        }



        // Метод для генерации случайного кода
        private string GenerateRandomCode()
        {
            Random rnd = new Random();
            int digitsCount = rnd.Next(3, 5);
            int lettersCount = 6 - digitsCount;
            string digits = new string(Enumerable.Range(0, digitsCount)
                .Select(_ => (char)('0' + rnd.Next(10))).ToArray());
            string letters = new string(Enumerable.Range(0, lettersCount)
                .Select(_ => (char)('A' + rnd.Next(26))).ToArray());
            string code = new string((digits + letters).OrderBy(c => rnd.Next()).ToArray());
            return code;
        }

        private async void SendCodeButton_Click(object sender, EventArgs e)
        {

            // Проверяем корректность введенного email перед отправкой
            if (!ValidateEmail() || !ValidateRegistration())
                return;

            string login = LoginTextBox.Text;

            // Проверка существования пользователя с таким же логином в базе данных

            // Генерируем случайный код
            string code = GenerateRandomCode();

            // Формируем письмо с кодом подтверждения
            MailAddress fromAddress = new MailAddress(EmailFrom, "Personal computer builder");
            MailAddress toAddress = new MailAddress(EmailTextBox.Text);
            MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Body = $"Здравствуйте, {LoginTextBox.Text}! Спасибо, что выбрали нас!\nВаш код для регистрации: {code}",
                Subject = "Спасибо за регистрацию!"
            };

            // Настройка SMTP клиента для отправки письма
            SmtpClient smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(EmailFrom, Password)
            };
            DB db = new DB();
            SqlConnection connection = db.getConnection();
            connection.Open();
            string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Login = @login OR Email=@mail";
            using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
            {
                checkUserCommand.Parameters.AddWithValue("@login", LoginTextBox.Text);
                checkUserCommand.Parameters.AddWithValue("@mail", EmailTextBox.Text);
                int userExists = (int)checkUserCommand.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("Данный логин или почта уже занят");
                    checkLog = false;
                }
                else
                    checkLog = true;
                if (checkLog == true)
                {

                    try
                    {
                        // Отправка письма с кодом подтверждения
                        await smtpClient.SendMailAsync(message);
                        MessageBox.Show("Письмо с кодом для регистрации отправлено на вашу почту.");
                        CodeForm cf = new CodeForm(code, LoginTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);
                        this.Hide();
                        cf.ShowDialog();
                        
                    }
                    catch (Exception ex)
                    {
                        // Обработка ошибок отправки письма
                        MessageBox.Show("Ошибка при отправке письма: " + ex.Message);

                    }


                }
            }
        }




        // Метод для валидации введенного email перед отправкой
        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Email'.");
                return false;
            }

            if (!IsValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.");
                EmailTextBox.Clear();
                return false;
            }

            return true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm af = new AuthorizationForm();
            this.Hide();
            af.Show();

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
        private void SendCodeButton_MouseEnter(object sender, EventArgs e)
        {
            SendCodeButton.BackColor = Color.RoyalBlue;
            SendCodeButton.ForeColor = Color.White;
        }

        private void SendCodeButton_MouseLeave(object sender, EventArgs e)
        {
            SendCodeButton.BackColor = Color.LightSteelBlue;
            SendCodeButton.ForeColor = Color.Black;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackColor = Color.RoyalBlue;
            backButton.ForeColor = Color.White;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.LightSteelBlue;
            backButton.ForeColor = Color.Black;
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

        private void ConfirmPasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.BackColor = Color.RoyalBlue;
            ConfirmPasswordTextBox.ForeColor = Color.White;
        }

        private void ConfirmPasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.BackColor = Color.LightSteelBlue;
            ConfirmPasswordTextBox.ForeColor = Color.Black;
        }

        private void EmailTextBox_MouseEnter(object sender, EventArgs e)
        {
            EmailTextBox.BackColor = Color.RoyalBlue;
            EmailTextBox.ForeColor = Color.White;
        }

        private void EmailTextBox_MouseLeave(object sender, EventArgs e)
        {
            EmailTextBox.BackColor = Color.LightSteelBlue;
            EmailTextBox.ForeColor = Color.Black;
        }
    }
}
