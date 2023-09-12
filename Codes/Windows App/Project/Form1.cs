using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Project
{
    public partial class Form1 : Form
    {
        int n, j;
        float pr, pr1;
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
        }
        private void serial()
        {

            try
            {
                tBoxdataout.Text = serialPort1.ReadExisting();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonopen_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARITYBITS.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void prs()
        {
            pr = 100 - ((100 * Tank_Level.Height) / 172);
            textBox1.Text = pr.ToString() + "%";
        }


        private void buttonclose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "Start")
            {
                timer1.Enabled = true;
                timer1.Interval = 50;
                serialPort1.Write("A");
                serial();
                start.Text = "Continue Fill";

            }
            if (start.Text == "Continue Fill")
            {
                timer1.Enabled = true;
                timer1.Interval = 50;
                serialPort1.Write("A");

                serial();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prs();
            n = n + 1;
            this.Tank_Level.Height = 172 - n;
            if (this.Tank_Level.Height <= 0)
            {
                timer1.Enabled = false;
                timer1.Stop();
                serialPort1.Write("C");
                serial();
                textBox1.Text += "\r\n" + "TANK IS FULL";
                MessageBox.Show("Tank Is Full", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            n = n - 1;
            this.Tank_Level.Height = 172 - n;
            prs();
            if (this.Tank_Level.Height >= 172)
            {
                timer2.Enabled = false;
                timer2.Stop();
                serialPort1.Write("C");
                serial();
                textBox1.Text += "\r\n" + "TANK IS EMPTY";
                MessageBox.Show("Tank Is EMPTY", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button_using_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 50;
            button_using.Text = "Continue Use";
            serialPort1.Write("B");
            serial();
        }

        private void tBoxdataout_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void ExportToExcel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (start.Text == "Continue Fill")
            {
                timer1.Stop();
                if (Tank_Level.Height > 0 && Tank_Level.Height < 172)
                {
                    start.Text = "Continue Fill";
                    serialPort1.Write("C");
                    serial();
                }

            }
            if (button_using.Text == "Continue Use")
            {
                timer2.Stop();
                if (Tank_Level.Height > 0 && Tank_Level.Height < 172)
                {
                    button_using.Text = "Continue Use";
                    serialPort1.Write("C");
                    serial();
                }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

    }
}
