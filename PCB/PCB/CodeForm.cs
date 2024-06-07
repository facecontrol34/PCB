using PCB;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class CodeForm : Form
    {
        private string _codeFromRegistration;
        private TextBox[] codeBoxes;
        private int currentCodeBoxIndex = 0;
        private const int MaxCodeLength = 1; // Максимальная длина кода в каждом текстовом поле
        private string log, pass, eMail = "";
        private bool isDragging = false;
        private Point lastCursorPosition;

        public string CodeFromRegistration
        {
            get { return _codeFromRegistration; }
            set { _codeFromRegistration = value; }
        }

        public CodeForm(string code, string login, string password, string email)
        {
            log = login;
            pass = password;
            eMail = email;
            InitializeComponent();
            CodeBoxesAttach(codeBox1);
            CodeBoxesAttach(codeBox2);
            CodeBoxesAttach(codeBox3);  
            CodeBoxesAttach(codeBox4);
            CodeBoxesAttach(codeBox5);
            CodeBoxesAttach(codeBox6);
            InitializeCodeTextBoxes();
            CodeFromRegistration = code; // Установка кода регистрации
        }

        private void InitializeCodeTextBoxes()
        {
            codeBoxes = new TextBox[] { codeBox1, codeBox2, codeBox3, codeBox4, codeBox5, codeBox6 };

            foreach (var textBox in codeBoxes)
            {
                textBox.KeyPress += CodeBox_KeyPress;
                textBox.MaxLength = MaxCodeLength; // Ограничение максимальной длины текста
                textBox.KeyDown += CodeBox_KeyDown; // Добавить обработчик для нажатия клавиш
                textBox.TextChanged += CodeBox_TextChanged; // Подписка на событие изменения текста
            }
        }

        private void CodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                TextBox currentTextBox = (TextBox)sender;
                currentTextBox.Clear(); // Очистить текстовое поле при нажатии кнопки Backspace
            }
        }

        private void CodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            // Проверяем, является ли символ буквой английского алфавита или цифрой
            if (!char.IsLetterOrDigit(e.KeyChar) || !IsEnglishLetterOrDigit(e.KeyChar))
            {
                // Если символ не является буквой английского алфавита или цифрой, игнорируем его
                e.Handled = true;
                return;
            }

            // Преобразовываем символ в верхний регистр
            e.KeyChar = char.ToUpper(e.KeyChar);

            // Устанавливаем курсор в конец текста
            currentTextBox.SelectionStart = currentTextBox.Text.Length;
            currentTextBox.SelectionLength = 0;
        }

        private bool IsEnglishLetterOrDigit(char c)
        {
            // Проверяем, является ли символ буквой английского алфавита или цифрой
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
        }

        private void CodeBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            // Перемещение курсора на следующее поле при вводе одного символа,
            // если текущее поле не находится в конце и не достигло максимальной длины
            if (currentTextBox.TextLength == MaxCodeLength)
            {
                MoveToNextCodeBox(currentTextBox);
            }
        }

        private void MoveToNextCodeBox(TextBox currentTextBox)
        {
            int currentIndex = Array.IndexOf(codeBoxes, currentTextBox);

            if (currentIndex < codeBoxes.Length - 1)
            {
                codeBoxes[currentIndex + 1].Focus();
            }
            else
            {
                ValidateEnteredCode();
            }
        }

        private void ValidateEnteredCode()
        {
            string enteredCode = string.Concat(codeBoxes.Select(tb => tb.Text));

            if (enteredCode == CodeFromRegistration)
            {
                MessageBox.Show("Код верный. Регистрация завершена!");

                // Хешируем пароль
                string hashedPassword = PasswordHasher.HashPassword(pass);

                // Запись данных пользователя в базу данных
                try
                {
                    DB db = new DB();
                    using (SqlConnection connection = db.getConnection())
                    {
                        connection.Open();

                        // Вставляем данные в таблицу userTable
                        string insertUserQuery = @"
                        INSERT INTO Users (Login, Password, Email)
                        OUTPUT INSERTED.UserID
                        VALUES (@login, @password, @name);";

                        int userId;
                        using (SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection))
                        {
                            insertUserCommand.Parameters.AddWithValue("@login", log);
                            insertUserCommand.Parameters.AddWithValue("@password", hashedPassword);
                            insertUserCommand.Parameters.AddWithValue("@name", eMail);

                            // Получаем ID нового пользователя
                            userId = (int)insertUserCommand.ExecuteScalar();
                        }
                    }

                    MainForm mf = new MainForm(eMail);
                    this.Close();
                    mf.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка при регистрации пользователя.");
                }
            }
            else
            {
                MessageBox.Show("Неверный код.");

                // Очистка всех текстовых полей
                foreach (var textBox in codeBoxes)
                {
                    textBox.Clear();
                }
                codeBoxes[0].Focus();
            }
        }

        private void CodeForm_Load(object sender, EventArgs e)
        {
            foreach (var textBox in codeBoxes)
            {
                textBox.MouseClick += TextBox_MouseClick;
            }
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

        // дизайн
        private void CodeBoxesAttach (TextBox textBox)
        {
            textBox.MouseEnter += TextBox_MouseEnter;
            textBox.MouseLeave += TextBox_MouseLeave;
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Изменение цвета фона при наведении мыши
            textBox.BackColor = Color.RoyalBlue;
            textBox.ForeColor = Color.White;
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Возвращение исходного цвета фона при уходе мыши
            textBox.BackColor = Color.LightSteelBlue;
            textBox.ForeColor= Color.Black;
        }


        private void TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Установите фокус на текстовом поле, чтобы начать редактирование текста
            TextBox textBox = (TextBox)sender;
            textBox.ReadOnly = false;
            textBox.Focus();
            textBox.SelectAll(); // Выделить весь текст при клике
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Открываем форму авторизации
            RegistrationForm form = new RegistrationForm();
            this.Close();
            form.Show();
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

    

    // Класс для хэширования паролей
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                // Преобразуем строку в массив байт
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                // Вычисляем хэш MD5
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Преобразуем массив байт в строку шестнадцатеричного представления
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
