namespace PCBuilder
{
    partial class FormIdTG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDChatTextBox = new System.Windows.Forms.TextBox();
            this.TGMessageButton = new System.Windows.Forms.Button();
            this.textlabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.botLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDChatTextBox
            // 
            this.IDChatTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.IDChatTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDChatTextBox.Location = new System.Drawing.Point(150, 63);
            this.IDChatTextBox.Name = "IDChatTextBox";
            this.IDChatTextBox.Size = new System.Drawing.Size(211, 32);
            this.IDChatTextBox.TabIndex = 0;
            this.IDChatTextBox.MouseEnter += new System.EventHandler(this.IDChatTextBox_MouseEnter);
            this.IDChatTextBox.MouseLeave += new System.EventHandler(this.IDChatTextBox_MouseLeave);
            // 
            // TGMessageButton
            // 
            this.TGMessageButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TGMessageButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TGMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TGMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TGMessageButton.Location = new System.Drawing.Point(0, 168);
            this.TGMessageButton.Name = "TGMessageButton";
            this.TGMessageButton.Size = new System.Drawing.Size(506, 31);
            this.TGMessageButton.TabIndex = 20;
            this.TGMessageButton.Text = "Отправить конфигурацию";
            this.TGMessageButton.UseVisualStyleBackColor = false;
            this.TGMessageButton.Click += new System.EventHandler(this.TGMessageButton_Click);
            this.TGMessageButton.MouseEnter += new System.EventHandler(this.TGMessageButton_MouseEnter);
            this.TGMessageButton.MouseLeave += new System.EventHandler(this.TGMessageButton_MouseLeave);
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textlabel.ForeColor = System.Drawing.Color.White;
            this.textlabel.Location = new System.Drawing.Point(36, 9);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(441, 19);
            this.textlabel.TabIndex = 21;
            this.textlabel.Text = "Пожалуйста, введите ID chat своего аккаунта telegram";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(36, 120);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(389, 45);
            this.infoLabel.TabIndex = 22;
            this.infoLabel.Text = "Чтобы узнать chat id, введите команду /get_chat_id в ";
            // 
            // botLabel
            // 
            this.botLabel.AutoSize = true;
            this.botLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.botLabel.ForeColor = System.Drawing.Color.Crimson;
            this.botLabel.Location = new System.Drawing.Point(419, 123);
            this.botLabel.Name = "botLabel";
            this.botLabel.Size = new System.Drawing.Size(49, 20);
            this.botLabel.TabIndex = 23;
            this.botLabel.Text = "бота";
            this.botLabel.Click += new System.EventHandler(this.botLabel_Click);
            this.botLabel.MouseEnter += new System.EventHandler(this.botLabel_MouseEnter);
            this.botLabel.MouseLeave += new System.EventHandler(this.botLabel_MouseLeave);
            // 
            // FormIdTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(506, 199);
            this.Controls.Add(this.botLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.TGMessageButton);
            this.Controls.Add(this.IDChatTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormIdTG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDChatTextBox;
        private System.Windows.Forms.Button TGMessageButton;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label botLabel;
    }
}