namespace PetrolScappngNaloga2
{
    partial class Naloga2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_fetchData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveDialog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 31);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // btn_fetchData
            // 
            this.btn_fetchData.Location = new System.Drawing.Point(11, 99);
            this.btn_fetchData.Name = "btn_fetchData";
            this.btn_fetchData.Size = new System.Drawing.Size(92, 43);
            this.btn_fetchData.TabIndex = 1;
            this.btn_fetchData.Text = "Go!";
            this.btn_fetchData.UseVisualStyleBackColor = true;
            this.btn_fetchData.Click += new System.EventHandler(this.btn_fetchData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vnesite željeni datum za prikaz podatkov:";
            // 
            // btn_saveDialog
            // 
            this.btn_saveDialog.Location = new System.Drawing.Point(428, 54);
            this.btn_saveDialog.Name = "btn_saveDialog";
            this.btn_saveDialog.Size = new System.Drawing.Size(140, 43);
            this.btn_saveDialog.TabIndex = 4;
            this.btn_saveDialog.Text = "Export as...";
            this.btn_saveDialog.UseVisualStyleBackColor = true;
            this.btn_saveDialog.Click += new System.EventHandler(this.btn_saveDialog_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(918, 708);
            this.dataGridView1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 905);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 37);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(310, 32);
            this.toolStripStatusLabel1.Text = "Naloga 2 - made by Alex. T.";
            // 
            // Naloga2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 942);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_saveDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fetchData);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Naloga2";
            this.Text = "Naloga 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_fetchData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;



    }
}

