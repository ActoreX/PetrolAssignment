namespace MojaPrvaWindowsFormsApp
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
            this.buttonExportData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUrlDesc = new System.Windows.Forms.Label();
            this.checkedListBoxCountrySelection = new System.Windows.Forms.CheckedListBox();
            this.labelCountrySelection = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericUpDownBackDays = new System.Windows.Forms.NumericUpDown();
            this.labelDaysDesc = new System.Windows.Forms.Label();
            this.labelDaysDescCon = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackDays)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExportData
            // 
            this.buttonExportData.Location = new System.Drawing.Point(12, 278);
            this.buttonExportData.Name = "buttonExportData";
            this.buttonExportData.Size = new System.Drawing.Size(187, 43);
            this.buttonExportData.TabIndex = 0;
            this.buttonExportData.Text = "Izvozi podatke!";
            this.buttonExportData.UseVisualStyleBackColor = true;
            this.buttonExportData.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 31);
            this.textBox1.TabIndex = 1;
            // 
            // labelUrlDesc
            // 
            this.labelUrlDesc.AutoSize = true;
            this.labelUrlDesc.Location = new System.Drawing.Point(7, 18);
            this.labelUrlDesc.Name = "labelUrlDesc";
            this.labelUrlDesc.Size = new System.Drawing.Size(661, 25);
            this.labelUrlDesc.TabIndex = 2;
            this.labelUrlDesc.Text = "Vnesite URL naslov XML dokumenta, za podatke o gibanju tečajnic:";
            // 
            // checkedListBoxCountrySelection
            // 
            this.checkedListBoxCountrySelection.CheckOnClick = true;
            this.checkedListBoxCountrySelection.FormattingEnabled = true;
            this.checkedListBoxCountrySelection.Items.AddRange(new object[] {
            "ZDA",
            "Poljska",
            "Romunija"});
            this.checkedListBoxCountrySelection.Location = new System.Drawing.Point(12, 125);
            this.checkedListBoxCountrySelection.Name = "checkedListBoxCountrySelection";
            this.checkedListBoxCountrySelection.Size = new System.Drawing.Size(366, 82);
            this.checkedListBoxCountrySelection.TabIndex = 3;
            // 
            // labelCountrySelection
            // 
            this.labelCountrySelection.AutoSize = true;
            this.labelCountrySelection.Location = new System.Drawing.Point(7, 97);
            this.labelCountrySelection.Name = "labelCountrySelection";
            this.labelCountrySelection.Size = new System.Drawing.Size(247, 25);
            this.labelCountrySelection.TabIndex = 4;
            this.labelCountrySelection.Text = "Izberite poljubne države:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(416, 38);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(306, 33);
            this.toolStripStatusLabel1.Text = "Naloga 1 - Made by Alex T.";
            // 
            // numericUpDownBackDays
            // 
            this.numericUpDownBackDays.Location = new System.Drawing.Point(12, 241);
            this.numericUpDownBackDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownBackDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBackDays.Name = "numericUpDownBackDays";
            this.numericUpDownBackDays.Size = new System.Drawing.Size(70, 31);
            this.numericUpDownBackDays.TabIndex = 6;
            this.numericUpDownBackDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDaysDesc
            // 
            this.labelDaysDesc.AutoSize = true;
            this.labelDaysDesc.Location = new System.Drawing.Point(7, 215);
            this.labelDaysDesc.Name = "labelDaysDesc";
            this.labelDaysDesc.Size = new System.Drawing.Size(251, 25);
            this.labelDaysDesc.TabIndex = 7;
            this.labelDaysDesc.Text = "Podatke želim za zadnjih";
            // 
            // labelDaysDescCon
            // 
            this.labelDaysDescCon.AutoSize = true;
            this.labelDaysDescCon.Location = new System.Drawing.Point(89, 243);
            this.labelDaysDescCon.Name = "labelDaysDescCon";
            this.labelDaysDescCon.Size = new System.Drawing.Size(47, 25);
            this.labelDaysDescCon.TabIndex = 8;
            this.labelDaysDescCon.Text = "dni.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Autofill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(416, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelDaysDescCon);
            this.Controls.Add(this.labelDaysDesc);
            this.Controls.Add(this.numericUpDownBackDays);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelCountrySelection);
            this.Controls.Add(this.checkedListBoxCountrySelection);
            this.Controls.Add(this.labelUrlDesc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExportData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Naloga 1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExportData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUrlDesc;
        private System.Windows.Forms.CheckedListBox checkedListBoxCountrySelection;
        private System.Windows.Forms.Label labelCountrySelection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDownBackDays;
        private System.Windows.Forms.Label labelDaysDesc;
        private System.Windows.Forms.Label labelDaysDescCon;
        private System.Windows.Forms.Button button2;
    }

}

