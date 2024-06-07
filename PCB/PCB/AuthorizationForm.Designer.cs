namespace PCB
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.pcbPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LoginTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(104, 29);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(184, 35);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.MouseEnter += new System.EventHandler(this.LoginTextBox_MouseEnter);
            this.LoginTextBox.MouseLeave += new System.EventHandler(this.LoginTextBox_MouseLeave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(104, 93);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(184, 35);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.MouseEnter += new System.EventHandler(this.PasswordTextBox_MouseEnter);
            this.PasswordTextBox.MouseLeave += new System.EventHandler(this.PasswordTextBox_MouseLeave);
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AuthorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorizationButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizationButton.Location = new System.Drawing.Point(63, 161);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(208, 33);
            this.AuthorizationButton.TabIndex = 4;
            this.AuthorizationButton.TabStop = false;
            this.AuthorizationButton.Text = "Войти";
            this.AuthorizationButton.UseVisualStyleBackColor = false;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            this.AuthorizationButton.MouseEnter += new System.EventHandler(this.AuthorizationButton_MouseEnter);
            this.AuthorizationButton.MouseLeave += new System.EventHandler(this.AuthorizationButton_MouseLeave);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.RegistrationLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(76, 279);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(182, 20);
            this.RegistrationLabel.TabIndex = 6;
            this.RegistrationLabel.Text = "Еще не зарегистрированы?";
            this.RegistrationLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            this.RegistrationLabel.MouseEnter += new System.EventHandler(this.RegistrationLabel_MouseEnter);
            this.RegistrationLabel.MouseLeave += new System.EventHandler(this.RegistrationLabel_MouseLeave);
            // 
            // pcbPicture
            // 
            this.pcbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcbPicture.Image = global::PCB.Properties.Resources.PCB;
            this.pcbPicture.Location = new System.Drawing.Point(12, 12);
            this.pcbPicture.Name = "pcbPicture";
            this.pcbPicture.Size = new System.Drawing.Size(85, 64);
            this.pcbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPicture.TabIndex = 7;
            this.pcbPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personal Computer Builder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 91);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.PasswordTextBox);
            this.panel2.Controls.Add(this.AuthorizationButton);
            this.panel2.Controls.Add(this.LoginTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 222);
            this.panel2.TabIndex = 12;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(326, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbPicture);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.PictureBox pcbPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

