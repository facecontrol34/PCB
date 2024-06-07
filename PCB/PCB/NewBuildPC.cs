using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using PCB;
using System.Text.RegularExpressions;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;

namespace PCBuilder
{
    public partial class newBuildPc : Form
    {
        decimal countPrice = 0;
        string pictures, names, dbs = "";
        int adm = 0;
        string email;
        string pMotherboard, pProcessor, pGraphics_Card, pRAM, pCPU_Cooler, pHard_Drive, pSSD_Drive, pPower_Supply, pComputerCase = "";
        public newBuildPc(int admC, string email)
        {
            adm = admC;
            this.email = email;
            InitializeComponent();
            ButtonAttach(MotherboardButton);
            ButtonAttach(ProcessorButton);
            ButtonAttach(GraphicsCardButton);
            ButtonAttach(RAMButton);
            ButtonAttach(CPUCoolerButton);
            ButtonAttach(HardDriveButton);
            ButtonAttach(SSDDriveButton);
            ButtonAttach(PowerSupplyButton);
            ButtonAttach(ComputerCaseButton);
            ButtonAttach(tgMessageButton);
            ButtonAttach(emailMessageButton);
            screenupADM();
            priceScreen("Motherboard", MotherboardLabel.Text);
            priceScreen("Processor", ProcessorLabel.Text);
            priceScreen("Graphics_Card", Graphics_cardLabel.Text);
            priceScreen("RAM", RAMLabel.Text);
            priceScreen("CPU_Cooler", CPU_CoolerLabel.Text);
            priceScreen("Hard_Drive", Hard_DriveLabel.Text);
            priceScreen("SSD_Drive", SSD_DriveLabel.Text);
            priceScreen("Power_Supply", Power_SupplyLabel.Text);
            priceScreen("ComputerCase", ComputerCaseLabel.Text);

            pictureInitialize("Motherboard", MotherboardLabel.Text, MotherboardPicture);
            pictureInitialize("Processor", ProcessorLabel.Text, ProcessorPicture);
            pictureInitialize("Graphics_Card", Graphics_cardLabel.Text, Graphics_cardPicture);
            pictureInitialize("RAM", RAMLabel.Text, RAMPicture);
            pictureInitialize("CPU_Cooler", CPU_CoolerLabel.Text, CPU_CollerPicture);
            pictureInitialize("Hard_Drive", Hard_DriveLabel.Text, Hard_DrivePicture);
            pictureInitialize("SSD_Drive", SSD_DriveLabel.Text, SSD_DrivePicture);
            pictureInitialize("Power_Supply", Power_SupplyLabel.Text, Power_SupplyPictrure);
            pictureInitialize("ComputerCase", ComputerCaseLabel.Text, ComputerCasePicture);
            MotherboardButton.Enabled = false;
            ProcessorButton.Enabled = false;
            GraphicsCardButton.Enabled = false;
            RAMButton.Enabled = false;
            CPUCoolerButton.Enabled = false;
            HardDriveButton.Enabled = false;
            SSDDriveButton.Enabled = false;
            PowerSupplyButton.Enabled = false;
            ComputerCaseButton.Enabled = false;
        }
        public newBuildPc(string email)
        {
            this.email = email;
            InitializeComponent();
            ButtonAttach(MotherboardButton);
            ButtonAttach(ProcessorButton);
            ButtonAttach(GraphicsCardButton);
            ButtonAttach(RAMButton);
            ButtonAttach(CPUCoolerButton);
            ButtonAttach(HardDriveButton);
            ButtonAttach(SSDDriveButton);
            ButtonAttach(PowerSupplyButton);
            ButtonAttach(ComputerCaseButton);
            ButtonAttach(tgMessageButton);
            ButtonAttach(emailMessageButton);
            screenup();
            try
            {
                priceScreen("Motherboard", MotherboardLabel.Text);
                priceScreen("Processor", ProcessorLabel.Text);
                priceScreen("Graphics_Card", Graphics_cardLabel.Text);
                priceScreen("RAM", RAMLabel.Text);
                priceScreen("CPU_Cooler", CPU_CoolerLabel.Text);
                priceScreen("Hard_Drive", Hard_DriveLabel.Text);
                priceScreen("SSD_Drive", SSD_DriveLabel.Text);
                priceScreen("Power_Supply", Power_SupplyLabel.Text);
                priceScreen("ComputerCase", ComputerCaseLabel.Text);
                pictureInitialize("Motherboard", MotherboardLabel.Text, MotherboardPicture);
                pictureInitialize("Processor", ProcessorLabel.Text, ProcessorPicture);
                pictureInitialize("Graphics_Card", Graphics_cardLabel.Text, Graphics_cardPicture);
                pictureInitialize("RAM", RAMLabel.Text, RAMPicture);
                pictureInitialize("CPU_Cooler", CPU_CoolerLabel.Text, CPU_CollerPicture);
                pictureInitialize("Hard_Drive", Hard_DriveLabel.Text, Hard_DrivePicture);
                pictureInitialize("SSD_Drive", SSD_DriveLabel.Text, SSD_DrivePicture);
                pictureInitialize("Power_Supply", Power_SupplyLabel.Text, Power_SupplyPictrure);
                pictureInitialize("ComputerCase", ComputerCaseLabel.Text, ComputerCasePicture);
            }
            catch { }

        }

        public void pictureInitialize(string nameDb, string model, PictureBox box)
        {
            DB db = new DB();
            string query = "SELECT Picture FROM " + nameDb +  " WHERE Model = @ses";
            SqlConnection connection = db.getConnection();
            connection.Open();
                SqlCommand command1 = new SqlCommand(query, connection);
                command1.Parameters.AddWithValue("@ses", model);
                string qq = command1.ExecuteScalar().ToString();
                box.Image = Image.FromFile(qq);
            connection.Close();
        }

        public newBuildPc(string picture, string name, string db)
        {
            pictures = picture;
            names = name;
            dbs = db;
            InitializeComponent();
            ButtonAttach(MotherboardButton);
            ButtonAttach(ProcessorButton);
            ButtonAttach(GraphicsCardButton);
            ButtonAttach(RAMButton);
            ButtonAttach(CPUCoolerButton);
            ButtonAttach(HardDriveButton);
            ButtonAttach(SSDDriveButton);
            ButtonAttach(PowerSupplyButton);
            ButtonAttach(ComputerCaseButton);
            ButtonAttach(tgMessageButton);
            ButtonAttach(emailMessageButton);

            screenup();

        }

        private void tgMessageButton_Click(object sender, EventArgs e)
        {

            string message =                 $"Спасибо, что пользуетесь нашим сервисом! \n\n" +
                                             $"Ваша конфигурация: \n" +
                                             $"Материнская плата: {MotherboardLabel.Text}\n" +
                                             $"Процессор: {ProcessorLabel.Text}\n" +
                                             $"Видеокарта: {Graphics_cardLabel.Text}\n" +
                                             $"ОЗУ: {RAMLabel.Text}\n" +
                                             $"Кулер: {CPU_CoolerLabel.Text}\n" +
                                             $"Жесткий диск: {Hard_DriveLabel.Text}\n" +
                                             $"SSD диск: {SSD_DriveLabel.Text}\n" +
                                             $"Блок питания: {Power_SupplyLabel.Text}\n" +
                                             $"Корпус: {ComputerCaseLabel.Text}";

            FormIdTG form2 = new FormIdTG(message);
            form2.ShowDialog();

        }

        void screenupADM()
        {
            DB db = new DB();

            string query = "SELECT * FROM SessionTable WHERE SessionID = @ses and UserID = 2";
            SqlConnection connection = db.getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ses", adm);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pMotherboard = reader.GetString(reader.GetOrdinal("Motherboard"));
                    pProcessor = reader.GetString(reader.GetOrdinal("Processor"));
                    pGraphics_Card = reader.GetString(reader.GetOrdinal("Graphics_Card"));
                    pRAM = reader.GetString(reader.GetOrdinal("RAM"));
                    pCPU_Cooler = reader.GetString(reader.GetOrdinal("CPU_Cooler"));
                    pHard_Drive = reader.GetString(reader.GetOrdinal("Hard_Drive"));
                    pSSD_Drive = reader.GetString(reader.GetOrdinal("SSD_Drive"));
                    pPower_Supply = reader.GetString(reader.GetOrdinal("Power_Supply"));
                    pComputerCase = reader.GetString(reader.GetOrdinal("ComputerCase"));
                }
                reader.Close();
            }

            MotherboardLabel.Text = pMotherboard;
            ProcessorLabel.Text = pProcessor;
            Graphics_cardLabel.Text = pGraphics_Card;
            RAMLabel.Text = pRAM;
            CPU_CoolerLabel.Text = pCPU_Cooler;
            Hard_DriveLabel.Text = pHard_Drive;
            SSD_DriveLabel.Text = pSSD_Drive;
            Power_SupplyLabel.Text = pPower_Supply;
            ComputerCaseLabel.Text = pComputerCase;

        }

        void priceScreen(string name, string model)
        {
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

                        PriceLabel.Text = "Общая стоимость: " + countPrice + "$";
                    }

                }
                catch
                {
                }
            }

        }

        // Отправка конфигурации на электронную почту
        private const string EmailFrom = "PCBuilder58@yandex.ru";
        private const string Password = "ofgljslytncnjmbj";
        private async void emailMessageButton_Click(object sender, EventArgs e)
        {
            string messageText = $"Материнская плата: {MotherboardLabel.Text}\n" +
                                            $"Процессор: {ProcessorLabel.Text}\n" +
                                            $"Видеокарта: {Graphics_cardLabel.Text}\n" +
                                            $"ОЗУ: {RAMLabel.Text}\n" +
                                            $"Кулер: {CPU_CoolerLabel.Text}\n" +
                                            $"Жесткий диск: {Hard_DriveLabel.Text}\n" +
                                            $"SSD диск: {SSD_DriveLabel.Text}\n" +
                                            $"Блок питания: {Power_SupplyLabel.Text}\n" +
                                            $"Корпус: {ComputerCaseLabel.Text}";
            MailAddress fromAddress = new MailAddress(EmailFrom, "Personal computer builder");
            MailAddress toAddress = new MailAddress(email);
            MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Body = messageText,
                Subject = "Комплектующие компьютера от PCBuilder!"
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
            try
            {
                // Отправка письма с кодом подтверждения
                await smtpClient.SendMailAsync(message);
                MessageBox.Show("Текущая конфигурация отправлена на вашу электронную почту: " + email);
            }
            catch (Exception ex)
            {
                // Обработка ошибок отправки письма
                MessageBox.Show("Ошибка при отправке письма: " + ex.Message);

            }

        }

        void screenup()
        {
            DB db = new DB();

            string query = "SELECT * FROM SessionTable WHERE SessionID = 1";
            SqlConnection connection = db.getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pMotherboard = reader.GetString(reader.GetOrdinal("Motherboard"));
                    pProcessor = reader.GetString(reader.GetOrdinal("Processor"));
                    pGraphics_Card = reader.GetString(reader.GetOrdinal("Graphics_Card"));
                    pRAM = reader.GetString(reader.GetOrdinal("RAM"));
                    pCPU_Cooler = reader.GetString(reader.GetOrdinal("CPU_Cooler"));
                    pHard_Drive = reader.GetString(reader.GetOrdinal("Hard_Drive"));
                    pSSD_Drive = reader.GetString(reader.GetOrdinal("SSD_Drive"));
                    pPower_Supply = reader.GetString(reader.GetOrdinal("Power_Supply"));
                    pComputerCase = reader.GetString(reader.GetOrdinal("ComputerCase"));
                }
                reader.Close();
            }

            MotherboardLabel.Text = pMotherboard;
            ProcessorLabel.Text = pProcessor;
            Graphics_cardLabel.Text = pGraphics_Card;
            RAMLabel.Text = pRAM;
            CPU_CoolerLabel.Text = pCPU_Cooler;
            Hard_DriveLabel.Text = pHard_Drive;
            SSD_DriveLabel.Text = pSSD_Drive;
            Power_SupplyLabel.Text = pPower_Supply;
            ComputerCaseLabel.Text = pComputerCase;

        }

        private void MotherboardButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("Motherboard", 3, "Материнская плата",email);
            this.Hide();
            form1.ShowDialog();

        }

        private void ProcessorButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("Processor", 3, "Процессор", email);
            this.Hide();
            form1.ShowDialog();
        }

        private void newBuildPc_Load(object sender, EventArgs e)
        {

        }



        private void GraphicsCardButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("Graphics_Card", 3, "Видеокарта", email);
            this.Hide();
            form1.ShowDialog();

        }

        private void RAMButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("RAM", 3, "Оперативная память", email);
            this.Hide();
            form1.ShowDialog();
        }

        private void CPUCoolerButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("CPU_Cooler", 3, "Куллер", email);
            this.Hide();
            form1.ShowDialog();
        }

        private void HardDriveButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("Hard_Drive", 3, "Жесткий диск", email);
            this.Hide();
            form1.ShowDialog();
        }

        private void SSDDriveButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("SSD_Drive", 3, "Твердотельный накопитель", email);
            this.Hide();
            form1.ShowDialog();
        }

        private void PowerSupplyButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("Power_Supply", 3, "Блок питания", email);
            this.Hide();
            form1.ShowDialog();
        }

        private void ComputerCaseButton_Click(object sender, EventArgs e)
        {
            FormComponentSelection form1 = new FormComponentSelection("ComputerCase", 3, "Корпус", email);
            this.Hide();
            form1.ShowDialog();
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

