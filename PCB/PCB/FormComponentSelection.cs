using PCBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PCB
{
    public partial class FormComponentSelection : Form
    {
        string nameBd = "";
        int lenght = 0;
        string email;
        public FormComponentSelection(string _name, int len, string nameForm, string email)
        {
            this.email = email;
            lenght = len;
            nameBd = _name;
            InitializeComponent();
            dataGridViewHar.AutoGenerateColumns = true;
            dataGridViewHar.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewHar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addRows();
            labelName.Text = nameForm;
        }
        void addRows()
        {
            DB db = new DB();
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT Model, Manufacturer, Price FROM " + nameBd;
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[lenght]);
                    for (int j = 0; j < lenght; j++)
                    {
                        data[data.Count - 1][j] = reader[j].ToString();

                    }
                }
                reader.Close();
                connection.Close();
                foreach (string[] s in data)
                    dataGridViewHar.Rows.Add(s);
            }
        }
        public void printInfoText(string name)
        {
            DB db = new DB();
            string[] data = new string[12];
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string query = "SELECT * FROM " + nameBd + " WHERE Model=@name"; //+ " AND" + " COLUMN_NAME NOT IN (Модель, Производитель, Цена)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    if (nameBd.Equals("Motherboard"))
                    {
                        string infoChar = " Форм фактор: " + reader[3].ToString() +
                          "    Тип разъема: " + reader[4].ToString() +
                            "\n Чипсет: " + reader[5].ToString() +
                            "   Поддержка процессоров: " + reader[6].ToString() +
                            "\n Количество слотов памяти: " + reader[7].ToString() +
                            "   Максимальная емкость памяти: " + reader[8].ToString() +
                             "\n Частота памяти: " + reader[9].ToString() +
                              "\n\n Обратитите внимание! Тип разъема мат. платы и процессора должны совпадать.";
                        labelInfo.Text = infoChar;

                    }


                    if (nameBd.Equals("Processor"))
                    {

                        string infoChar = " Частота процесоора: " + reader[3].ToString() +
                          "    Количество ядер: " + reader[4].ToString() +
                            "\n Количество потоков: " + reader[5].ToString() +
                            "  Кэш : " + reader[6].ToString() +
                            "\n Техпроцесс: " + reader[7].ToString() +
                            "   Тип разъема " + reader[8].ToString() + 
                            "\n\n Обратитите внимание! Тип разъема процессора и мат. платы должны совпадать.";
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("Graphics_Card"))
                    {
                        string infoChar = " Видеопамять: " + reader[3].ToString() +
                          "    Тип памяти: " + reader[4].ToString() +
                            "\n Тип подключения: " + reader[5].ToString() +
                            "  Частота процессора : " + reader[6].ToString();
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("RAM"))
                    {
                        string infoChar = " Объем памяти: " + reader[3].ToString() +
                          "    Тип памяти: " + reader[4].ToString() +
                            "\n Частота памяти: " + reader[5].ToString() +
                            "  Тайминги : " + reader[6].ToString() +
                        "\n\n Обратитите внимание! Частота памяти RAM будет ограничена частотой памяти мат. платы.";
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("CPU_Cooler"))
                    {
                        string infoChar = " Тип: " + reader[3].ToString() +
                    "    Совместимость с разъемами: " + reader[4].ToString() +
                      "\n Тип подшипника: " + reader[5].ToString() +
                      "  Разъем вентилятора : " + reader[6].ToString() +
                      "\n Максимальный уровень шума : " + reader[7].ToString() +
                       "\n\n Обратитите внимание! Кулер должн быть совместим с разьемом процессора.";
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("Hard_Drive"))
                    {
                        string infoChar = " Объем памяти: " + reader[3].ToString() +
                          "    Тип интерфейса: " + reader[4].ToString() +
                            "\n Скорость вращения: " + reader[5].ToString() +
                            "  Среднее время поиска : " + reader[6].ToString();
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("SSD_Drive"))
                    {
                        string infoChar = " Объем памяти: " + reader[3].ToString() +
                          "    Тип интерфейса: " + reader[4].ToString() +
                            "\n Скорость чтения: " + reader[5].ToString() +
                            "  Скорость вращения : " + reader[6].ToString();
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("Power_Supply"))
                    {
                        string infoChar = " Мощность: " + reader[3].ToString() +
                          "    Эффективность: " + reader[4].ToString() +
                            "\n Колччество разъемов: " + reader[5].ToString();
                        labelInfo.Text = infoChar;
                    }
                    if (nameBd.Equals("ComputerCase"))
                    {
                        string infoChar = " Форм фактор: " + reader[3].ToString() +
                                          "\n\n Обратитите внимание! Форм фактор корпуса и материнской платы должны совпадать.";
                        labelInfo.Text = infoChar;
                    }
                }
                reader.Close();
            }
        }
        private void dataGridViewHar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewHar.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string name = dataGridViewHar.Rows[index].Cells[0].Value.ToString();

                DB db = new DB();

                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    printInfoText(name);
                    string quary1 = "SELECT Picture FROM " + nameBd + " WHERE Model=@name";
                   SqlCommand command1 = new SqlCommand(quary1, connection);
                   command1.Parameters.AddWithValue("@name", name);
                   string imagePath = command1.ExecuteScalar().ToString();
                  // pictureBoxDetails.Image = null;
                   pictureBoxDetails.Image = Image.FromFile(imagePath);
                    //C:\\Users\\facec\\Downloads\\qq.jpg
                    //reader.Close();
                    connection.Close();
                }
            }
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string model = "";
            int index = dataGridViewHar.CurrentCell.RowIndex;
            if (index >= 0)
            {
                DB db = new DB();

                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string selQuar = nameBd + "ID";
                    model = dataGridViewHar.Rows[index].Cells[0].Value.ToString();
                    string query = " UPDATE SessionTable SET " + nameBd + " = @newName WHERE SessionID = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newName", model);
                    command.ExecuteNonQuery();
                }

                newBuildPc form = new newBuildPc(email);
                this.Hide();
                form.ShowDialog();
            }
        }
        private void ThisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                newBuildPc nb = new newBuildPc(email);
                this.Hide();
                nb.ShowDialog();
                
            }
        }

        private void buttonSelect_MouseEnter(object sender, EventArgs e)
        {
            buttonSelect.BackColor = Color.RoyalBlue;
            buttonSelect.ForeColor = Color.White;
        }

        private void buttonSelect_MouseLeave(object sender, EventArgs e)
        {
            buttonSelect.BackColor = Color.LightSteelBlue;
            buttonSelect.ForeColor = Color.Black;
        }
    }
}
