namespace Naloga3
{
    partial class Form1
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
            this.btn_fetchData = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_fetchDataDesc = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.comboBox_market = new System.Windows.Forms.ComboBox();
            this.labelChooseMarket = new System.Windows.Forms.Label();
            this.folderBrowserDialogDestFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxLTGlavnaPath = new System.Windows.Forms.TextBox();
            this.labelLTGlavnaPath = new System.Windows.Forms.Label();
            this.labelLTPodpornaPath = new System.Windows.Forms.Label();
            this.textBoxLTPodpornaPath = new System.Windows.Forms.TextBox();
            this.btn_chooseLTGlavna = new System.Windows.Forms.Button();
            this.btn_chooseLTPodporna = new System.Windows.Forms.Button();
            this.pictureBoxCubeGif = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCubeGif)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fetchData
            // 
            this.btn_fetchData.Location = new System.Drawing.Point(12, 321);
            this.btn_fetchData.Name = "btn_fetchData";
            this.btn_fetchData.Size = new System.Drawing.Size(764, 125);
            this.btn_fetchData.TabIndex = 0;
            this.btn_fetchData.Text = "Fetch data!";
            this.btn_fetchData.UseVisualStyleBackColor = true;
            this.btn_fetchData.Click += new System.EventHandler(this.btn_fetchData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(305, 32);
            this.toolStripStatusLabel1.Text = "Naloga 3 - made by Alex T.";
            // 
            // label_fetchDataDesc
            // 
            this.label_fetchDataDesc.Location = new System.Drawing.Point(12, 145);
            this.label_fetchDataDesc.Name = "label_fetchDataDesc";
            this.label_fetchDataDesc.Size = new System.Drawing.Size(764, 50);
            this.label_fetchDataDesc.TabIndex = 2;
            this.label_fetchDataDesc.Text = "Press button to fetch the data from URL: https://kapalk1.mavir.hu/kapar/lt-public" +
    "ation.jsp?locale=en_GB ";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(542, 51);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(234, 31);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(400, 56);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(111, 25);
            this.labelDateFrom.TabIndex = 4;
            this.labelDateFrom.Text = "Date from:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(425, 103);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(87, 25);
            this.labelDateTo.TabIndex = 6;
            this.labelDateTo.Text = "Date to:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(542, 98);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(234, 31);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // comboBox_market
            // 
            this.comboBox_market.FormattingEnabled = true;
            this.comboBox_market.Items.AddRange(new object[] {
            "All",
            "monthly",
            "yearly",
            "user defined"});
            this.comboBox_market.Location = new System.Drawing.Point(18, 53);
            this.comboBox_market.Name = "comboBox_market";
            this.comboBox_market.Size = new System.Drawing.Size(300, 33);
            this.comboBox_market.TabIndex = 7;
            this.comboBox_market.Leave += new System.EventHandler(this.comboBox_market_Leave);
            // 
            // labelChooseMarket
            // 
            this.labelChooseMarket.AutoSize = true;
            this.labelChooseMarket.Location = new System.Drawing.Point(12, 25);
            this.labelChooseMarket.Name = "labelChooseMarket";
            this.labelChooseMarket.Size = new System.Drawing.Size(240, 25);
            this.labelChooseMarket.TabIndex = 8;
            this.labelChooseMarket.Text = "Choose desired market:";
            // 
            // textBoxLTGlavnaPath
            // 
            this.textBoxLTGlavnaPath.Location = new System.Drawing.Point(168, 211);
            this.textBoxLTGlavnaPath.Name = "textBoxLTGlavnaPath";
            this.textBoxLTGlavnaPath.ReadOnly = true;
            this.textBoxLTGlavnaPath.Size = new System.Drawing.Size(542, 31);
            this.textBoxLTGlavnaPath.TabIndex = 12;
            // 
            // labelLTGlavnaPath
            // 
            this.labelLTGlavnaPath.AutoSize = true;
            this.labelLTGlavnaPath.Location = new System.Drawing.Point(12, 217);
            this.labelLTGlavnaPath.Name = "labelLTGlavnaPath";
            this.labelLTGlavnaPath.Size = new System.Drawing.Size(111, 25);
            this.labelLTGlavnaPath.TabIndex = 13;
            this.labelLTGlavnaPath.Text = "LT Glavna";
            // 
            // labelLTPodpornaPath
            // 
            this.labelLTPodpornaPath.AutoSize = true;
            this.labelLTPodpornaPath.Location = new System.Drawing.Point(13, 262);
            this.labelLTPodpornaPath.Name = "labelLTPodpornaPath";
            this.labelLTPodpornaPath.Size = new System.Drawing.Size(136, 25);
            this.labelLTPodpornaPath.TabIndex = 14;
            this.labelLTPodpornaPath.Text = "LT Podporna";
            // 
            // textBoxLTPodpornaPath
            // 
            this.textBoxLTPodpornaPath.Location = new System.Drawing.Point(168, 256);
            this.textBoxLTPodpornaPath.Name = "textBoxLTPodpornaPath";
            this.textBoxLTPodpornaPath.ReadOnly = true;
            this.textBoxLTPodpornaPath.Size = new System.Drawing.Size(542, 31);
            this.textBoxLTPodpornaPath.TabIndex = 15;
            // 
            // btn_chooseLTGlavna
            // 
            this.btn_chooseLTGlavna.Location = new System.Drawing.Point(716, 210);
            this.btn_chooseLTGlavna.Name = "btn_chooseLTGlavna";
            this.btn_chooseLTGlavna.Size = new System.Drawing.Size(60, 42);
            this.btn_chooseLTGlavna.TabIndex = 16;
            this.btn_chooseLTGlavna.Text = "...";
            this.btn_chooseLTGlavna.UseVisualStyleBackColor = true;
            this.btn_chooseLTGlavna.Click += new System.EventHandler(this.btn_chooseLTGlavna_Click);
            // 
            // btn_chooseLTPodporna
            // 
            this.btn_chooseLTPodporna.Location = new System.Drawing.Point(716, 254);
            this.btn_chooseLTPodporna.Name = "btn_chooseLTPodporna";
            this.btn_chooseLTPodporna.Size = new System.Drawing.Size(60, 42);
            this.btn_chooseLTPodporna.TabIndex = 17;
            this.btn_chooseLTPodporna.Text = "...";
            this.btn_chooseLTPodporna.UseVisualStyleBackColor = true;
            this.btn_chooseLTPodporna.Click += new System.EventHandler(this.btn_chooseLTPodporna_Click);
            // 
            // pictureBoxCubeGif
            // 
            this.pictureBoxCubeGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCubeGif.Location = new System.Drawing.Point(297, 467);
            this.pictureBoxCubeGif.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBoxCubeGif.Name = "pictureBoxCubeGif";
            this.pictureBoxCubeGif.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCubeGif.TabIndex = 18;
            this.pictureBoxCubeGif.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 729);
            this.Controls.Add(this.pictureBoxCubeGif);
            this.Controls.Add(this.btn_chooseLTPodporna);
            this.Controls.Add(this.btn_chooseLTGlavna);
            this.Controls.Add(this.textBoxLTPodpornaPath);
            this.Controls.Add(this.labelLTPodpornaPath);
            this.Controls.Add(this.labelLTGlavnaPath);
            this.Controls.Add(this.textBoxLTGlavnaPath);
            this.Controls.Add(this.labelChooseMarket);
            this.Controls.Add(this.comboBox_market);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label_fetchDataDesc);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_fetchData);
            this.MaximumSize = new System.Drawing.Size(814, 800);
            this.MinimumSize = new System.Drawing.Size(814, 800);
            this.Name = "Form1";
            this.Text = "Naloga 3";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCubeGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btn_fetchData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label_fetchDataDesc;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ComboBox comboBox_market;
        private System.Windows.Forms.Label labelChooseMarket;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestFolder;
        private System.Windows.Forms.TextBox textBoxLTGlavnaPath;
        private System.Windows.Forms.Label labelLTGlavnaPath;
        private System.Windows.Forms.Label labelLTPodpornaPath;
        private System.Windows.Forms.TextBox textBoxLTPodpornaPath;
        private System.Windows.Forms.Button btn_chooseLTGlavna;
        private System.Windows.Forms.Button btn_chooseLTPodporna;
        private System.Windows.Forms.PictureBox pictureBoxCubeGif;
    }
}

