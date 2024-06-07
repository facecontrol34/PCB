namespace PCB
{
    partial class FormComponentSelection
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewHar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHar
            // 
            this.dataGridViewHar.AllowUserToAddRows = false;
            this.dataGridViewHar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewHar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewHar.Location = new System.Drawing.Point(45, 86);
            this.dataGridViewHar.Name = "dataGridViewHar";
            this.dataGridViewHar.ReadOnly = true;
            this.dataGridViewHar.Size = new System.Drawing.Size(516, 237);
            this.dataGridViewHar.TabIndex = 5;
            this.dataGridViewHar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHar_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Модель";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Производитель";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(54, 335);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(89, 16);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Характеристики";
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(0, 482);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(818, 41);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            this.buttonSelect.MouseEnter += new System.EventHandler(this.buttonSelect_MouseEnter);
            this.buttonSelect.MouseLeave += new System.EventHandler(this.buttonSelect_MouseLeave);
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.BackColor = System.Drawing.Color.White;
            this.pictureBoxDetails.Location = new System.Drawing.Point(604, 128);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(155, 139);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetails.TabIndex = 7;
            this.pictureBoxDetails.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(298, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(185, 24);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Материнская плата";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 87);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(789, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 437);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 437);
            this.panel3.TabIndex = 12;
            // 
            // FormComponentSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 523);
            this.Controls.Add(this.dataGridViewHar);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.pictureBoxDetails);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormComponentSelection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}