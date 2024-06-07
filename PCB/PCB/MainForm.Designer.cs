namespace PCBuilder
{
    partial class MainForm
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
            this.Sample_button = new System.Windows.Forms.Button();
            this.New_build_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recButton = new System.Windows.Forms.Button();
            this.lnfousLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbPicture = new System.Windows.Forms.PictureBox();
            this.tgBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sample_button
            // 
            this.Sample_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Sample_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sample_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sample_button.Location = new System.Drawing.Point(498, 99);
            this.Sample_button.Name = "Sample_button";
            this.Sample_button.Size = new System.Drawing.Size(126, 76);
            this.Sample_button.TabIndex = 13;
            this.Sample_button.TabStop = false;
            this.Sample_button.Text = "Рекомендуемые конфигурации";
            this.Sample_button.UseVisualStyleBackColor = false;
            this.Sample_button.Click += new System.EventHandler(this.Sample_button_Click);
            // 
            // New_build_button
            // 
            this.New_build_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.New_build_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_build_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_build_button.Location = new System.Drawing.Point(89, 99);
            this.New_build_button.Name = "New_build_button";
            this.New_build_button.Size = new System.Drawing.Size(126, 76);
            this.New_build_button.TabIndex = 10;
            this.New_build_button.TabStop = false;
            this.New_build_button.Text = "Новая сборка";
            this.New_build_button.UseVisualStyleBackColor = false;
            this.New_build_button.Click += new System.EventHandler(this.New_build_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(370, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // recButton
            // 
            this.recButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.recButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recButton.Location = new System.Drawing.Point(187, 205);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(317, 33);
            this.recButton.TabIndex = 16;
            this.recButton.TabStop = false;
            this.recButton.Text = "Рекомендации";
            this.recButton.UseVisualStyleBackColor = false;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // lnfousLabel
            // 
            this.lnfousLabel.AutoSize = true;
            this.lnfousLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.lnfousLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnfousLabel.ForeColor = System.Drawing.Color.White;
            this.lnfousLabel.Location = new System.Drawing.Point(221, 175);
            this.lnfousLabel.Name = "lnfousLabel";
            this.lnfousLabel.Size = new System.Drawing.Size(263, 20);
            this.lnfousLabel.TabIndex = 19;
            this.lnfousLabel.Text = "Ознакомьтесь до подбора комплектующих";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Personal Computer Builder";
            // 
            // pcbPicture
            // 
            this.pcbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcbPicture.Image = global::PCB.Properties.Resources.PCB;
            this.pcbPicture.Location = new System.Drawing.Point(3, 2);
            this.pcbPicture.Name = "pcbPicture";
            this.pcbPicture.Size = new System.Drawing.Size(85, 64);
            this.pcbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPicture.TabIndex = 20;
            this.pcbPicture.TabStop = false;
            // 
            // tgBox
            // 
            this.tgBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.tgBox.BackgroundImage = global::PCB.Properties.Resources._2111710;
            this.tgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tgBox.Image = global::PCB.Properties.Resources.png_clipart_computer_icons_scalable_graphics_blue_youtube_icon_ico_computer_icons_telegram;
            this.tgBox.InitialImage = global::PCB.Properties.Resources._2111710;
            this.tgBox.Location = new System.Drawing.Point(310, 99);
            this.tgBox.Name = "tgBox";
            this.tgBox.Size = new System.Drawing.Size(77, 71);
            this.tgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tgBox.TabIndex = 18;
            this.tgBox.TabStop = false;
            this.tgBox.Click += new System.EventHandler(this.tgBox_Click);
            this.tgBox.MouseEnter += new System.EventHandler(this.tgBox_MouseEnter);
            this.tgBox.MouseLeave += new System.EventHandler(this.tgBox_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lnfousLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 243);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 66);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Связь с нами";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(699, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbPicture);
            this.Controls.Add(this.tgBox);
            this.Controls.Add(this.recButton);
            this.Controls.Add(this.Sample_button);
            this.Controls.Add(this.New_build_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sample_button;
        private System.Windows.Forms.Button New_build_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button recButton;
        private System.Windows.Forms.PictureBox tgBox;
        private System.Windows.Forms.Label lnfousLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}