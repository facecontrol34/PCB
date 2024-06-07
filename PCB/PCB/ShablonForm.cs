using PCBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PCB
{
    public partial class ShablonForm : Form
    {
        string email = "";
        public ShablonForm(string email)
        {
            InitializeComponent();
            ButtonAttach(CFG1);
            ButtonAttach(CFG2);
            ButtonAttach(CFG3);
            ButtonAttach(ConfigPC1Button);
            ButtonAttach(ConfigPC2Button);
            ButtonAttach(ConfigPC3Button);
            this.email = email;
        }

        private void ShablonForm_Load(object sender, EventArgs e)
        {
            price1.Text =  "Цена: "+ priceInitialize(2).ToString() + "$";
            price2.Text = "Цена: " + priceInitialize(3).ToString() + "$";
            price3.Text = "Цена: " + priceInitialize(4).ToString() + "$";

        }

        decimal priceScreen(string name, string model)
        {
            decimal countPrice = 0;
            DB db = new DB();
            string query = "SELECT Price FROM " + name + " WHERE Model = @mod";
            SqlConnection connection = db.getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@mod", model);
                connection.Open();


                try
                {
                    if (model.Length > 3)
                    {

                        countPrice += (decimal)command.ExecuteScalar();

                    }

                }
                catch
                {
                }
            }
            return countPrice;

        }
         decimal priceInitialize(int idNum)
        {
            decimal price = 0;
            DB db = new DB();
            string[] data = new string[12];
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SessionTable WHERE SessionID = @ses and UserID = 2"; //+ " AND" + " COLUMN_NAME NOT IN (Модель, Производитель, Цена)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ses", idNum);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                  price +=  priceScreen("Motherboard", reader[2].ToString());
                    price += priceScreen("Processor", reader[3].ToString());
                    price += priceScreen("Graphics_Card", reader[4].ToString());
                    price += priceScreen("RAM", reader[6].ToString());
                    price += priceScreen("CPU_Cooler", reader[5].ToString());
                    price += priceScreen("Hard_Drive", reader[7].ToString());
                    price += priceScreen("SSD_Drive", reader[8].ToString());
                    price += priceScreen("Power_Supply", reader[9].ToString());
                    price += priceScreen("ComputerCase", reader[10].ToString());
                }

            }
            return price;
        }

        private void ConfigPC1Button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string[] data = new string[12];
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SessionTable WHERE SessionID = @ses and UserID = 2"; //+ " AND" + " COLUMN_NAME NOT IN (Модель, Производитель, Цена)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ses", 2);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Материнская плата:" + reader[2].ToString()
                        + "\n Процессор: " + reader[3].ToString() +
                        "\n Видео карта: " + reader[4].ToString() +
                        "\n Куллер: " + reader[5].ToString() +
                        "\n ОЗУ: " + reader[6].ToString() +
                        "\n Жесткий диск: " + reader[7].ToString() +
                        "\n SSD диск: " + reader[8].ToString() +
                        "\n Блок питания: " + reader[9].ToString() +
                        "\n Корпус: " + reader[10].ToString()
                        , "Список", MessageBoxButtons.OK);
                }
            }
        }

        private void ConfigPC2Button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string[] data = new string[12];
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SessionTable WHERE SessionID = @ses and UserID = 2"; //+ " AND" + " COLUMN_NAME NOT IN (Модель, Производитель, Цена)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ses", 3);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Материнская плата:" + reader[2].ToString()
                        + "\n Процессор: " + reader[3].ToString() +
                        "\n Видео карта: " + reader[4].ToString() +
                        "\n Куллер: " + reader[5].ToString() +
                        "\n ОЗУ: " + reader[6].ToString() +
                        "\n Жесткий диск: " + reader[7].ToString() +
                        "\n SSD диск: " + reader[8].ToString() +
                        "\n Блок питания: " + reader[9].ToString() +
                        "\n Корпус: " + reader[10].ToString()
                        , "Список", MessageBoxButtons.OK);
                }
            }
        }

        private void ConfigPC3Button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string[] data = new string[12];
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SessionTable WHERE SessionID = @ses and UserID = 2"; //+ " AND" + " COLUMN_NAME NOT IN (Модель, Производитель, Цена)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ses", 4);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Материнская плата:" + reader[2].ToString()
                        + "\n Процессор: " + reader[3].ToString() +
                        "\n Видео карта: " + reader[4].ToString() +
                        "\n Куллер: " + reader[5].ToString() +
                        "\n ОЗУ: " + reader[6].ToString() +
                        "\n Жесткий диск: " + reader[7].ToString() +
                        "\n SSD диск: " + reader[8].ToString() +
                        "\n Блок питания: " + reader[9].ToString() +
                        "\n Корпус: " + reader[10].ToString()
                        , "Список", MessageBoxButtons.OK);
                }
            }
        }

        private void CFG1_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(2, email);
            form.ShowDialog();
        }

        private void CFG2_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(3, email);
            form.ShowDialog();
        }

        private void CFG3_Click(object sender, EventArgs e)
        {
            newBuildPc form = new newBuildPc(4, email);
            form.ShowDialog();
        }

        // дизайн 
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
