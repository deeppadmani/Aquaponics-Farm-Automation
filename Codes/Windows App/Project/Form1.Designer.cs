namespace Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonopen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.cBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.tBoxdataout = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Close = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_using = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DISPLAY = new System.Windows.Forms.GroupBox();
            this.Tank_Level = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Tank_eLevel = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DISPLAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tank_Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank_eLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonclose);
            this.groupBox1.Controls.Add(this.buttonopen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.cBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.cBoxDATABITS);
            this.groupBox1.Controls.Add(this.cBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(289, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 198);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(155, 234);
            this.buttonclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(105, 34);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.Text = "CLOSE";
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonopen
            // 
            this.buttonopen.Location = new System.Drawing.Point(16, 234);
            this.buttonopen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(105, 34);
            this.buttonopen.TabIndex = 11;
            this.buttonopen.Text = "OPEN";
            this.buttonopen.UseVisualStyleBackColor = true;
            this.buttonopen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            // 
            // cBoxPARITYBITS
            // 
            this.cBoxPARITYBITS.FormattingEnabled = true;
            this.cBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cBoxPARITYBITS.Location = new System.Drawing.Point(112, 165);
            this.cBoxPARITYBITS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxPARITYBITS.Name = "cBoxPARITYBITS";
            this.cBoxPARITYBITS.Size = new System.Drawing.Size(147, 24);
            this.cBoxPARITYBITS.TabIndex = 5;
            this.cBoxPARITYBITS.Text = "None";
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.AutoCompleteCustomSource.AddRange(new string[] {
            "9600",
            "4800"});
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(112, 65);
            this.cBoxBAUDRATE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(147, 24);
            this.cBoxBAUDRATE.TabIndex = 4;
            this.cBoxBAUDRATE.Text = "9600";
            // 
            // cBoxDATABITS
            // 
            this.cBoxDATABITS.FormattingEnabled = true;
            this.cBoxDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDATABITS.Location = new System.Drawing.Point(112, 98);
            this.cBoxDATABITS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxDATABITS.Name = "cBoxDATABITS";
            this.cBoxDATABITS.Size = new System.Drawing.Size(147, 24);
            this.cBoxDATABITS.TabIndex = 3;
            this.cBoxDATABITS.Text = "8";
            // 
            // cBoxSTOPBITS
            // 
            this.cBoxSTOPBITS.AutoCompleteCustomSource.AddRange(new string[] {
            "On",
            "Two"});
            this.cBoxSTOPBITS.FormattingEnabled = true;
            this.cBoxSTOPBITS.Location = new System.Drawing.Point(112, 132);
            this.cBoxSTOPBITS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxSTOPBITS.Name = "cBoxSTOPBITS";
            this.cBoxSTOPBITS.Size = new System.Drawing.Size(147, 24);
            this.cBoxSTOPBITS.TabIndex = 2;
            this.cBoxSTOPBITS.Text = "One";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(112, 32);
            this.cBoxCOMPORT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(147, 24);
            this.cBoxCOMPORT.TabIndex = 1;
            // 
            // tBoxdataout
            // 
            this.tBoxdataout.Location = new System.Drawing.Point(313, 85);
            this.tBoxdataout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxdataout.MaxLength = 65535;
            this.tBoxdataout.Multiline = true;
            this.tBoxdataout.Name = "tBoxdataout";
            this.tBoxdataout.ReadOnly = true;
            this.tBoxdataout.Size = new System.Drawing.Size(291, 235);
            this.tBoxdataout.TabIndex = 2;
            this.tBoxdataout.TextChanged += new System.EventHandler(this.tBoxdataout_TextChanged);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1145, 377);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(115, 37);
            this.Close.TabIndex = 4;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_using
            // 
            this.button_using.Location = new System.Drawing.Point(465, 373);
            this.button_using.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_using.Name = "button_using";
            this.button_using.Size = new System.Drawing.Size(180, 41);
            this.button_using.TabIndex = 38;
            this.button_using.Text = "Start Using Water";
            this.button_using.UseVisualStyleBackColor = true;
            this.button_using.Click += new System.EventHandler(this.button_using_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 90);
            this.textBox1.TabIndex = 18;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(36, 87);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(256, 54);
            this.stop.TabIndex = 8;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(36, 28);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 52);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Location = new System.Drawing.Point(947, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(321, 158);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOTOR CONTROL";
            // 
            // DISPLAY
            // 
            this.DISPLAY.Controls.Add(this.textBox1);
            this.DISPLAY.Location = new System.Drawing.Point(947, 69);
            this.DISPLAY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DISPLAY.Name = "DISPLAY";
            this.DISPLAY.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DISPLAY.Size = new System.Drawing.Size(321, 135);
            this.DISPLAY.TabIndex = 37;
            this.DISPLAY.TabStop = false;
            this.DISPLAY.Text = "DISPLAY";
            // 
            // Tank_Level
            // 
            this.Tank_Level.Image = ((System.Drawing.Image)(resources.GetObject("Tank_Level.Image")));
            this.Tank_Level.Location = new System.Drawing.Point(720, 150);
            this.Tank_Level.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tank_Level.Name = "Tank_Level";
            this.Tank_Level.Size = new System.Drawing.Size(133, 212);
            this.Tank_Level.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tank_Level.TabIndex = 31;
            this.Tank_Level.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 341);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(713, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(697, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(-1, 10);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1717, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 33;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(769, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // Tank_eLevel
            // 
            this.Tank_eLevel.Image = ((System.Drawing.Image)(resources.GetObject("Tank_eLevel.Image")));
            this.Tank_eLevel.Location = new System.Drawing.Point(720, 151);
            this.Tank_eLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tank_eLevel.Name = "Tank_eLevel";
            this.Tank_eLevel.Size = new System.Drawing.Size(133, 212);
            this.Tank_eLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tank_eLevel.TabIndex = 30;
            this.Tank_eLevel.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 449);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(739, 327);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Location = new System.Drawing.Point(603, 784);
            this.ExportToExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(168, 52);
            this.ExportToExcel.TabIndex = 40;
            this.ExportToExcel.Text = "ExportToExcel";
            this.ExportToExcel.UseVisualStyleBackColor = true;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 922);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_using);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tBoxdataout);
            this.Controls.Add(this.DISPLAY);
            this.Controls.Add(this.Tank_Level);
            this.Controls.Add(this.Tank_eLevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.DISPLAY.ResumeLayout(false);
            this.DISPLAY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tank_Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank_eLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonopen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPARITYBITS;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.ComboBox cBoxDATABITS;
        private System.Windows.Forms.ComboBox cBoxSTOPBITS;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.TextBox tBoxdataout;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_using;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox DISPLAY;
        private System.Windows.Forms.PictureBox Tank_Level;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Tank_eLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExportToExcel;
    }
}

