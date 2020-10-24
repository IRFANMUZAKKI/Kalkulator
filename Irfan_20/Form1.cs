using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irfan_20
{
    public partial class Form1 : Form
    {
        double value;
        string tomboluntukdioperasikan;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolangkaku(object sender, EventArgs e)
        {
            if((tomboluntukdioperasikan == "+") || (tomboluntukdioperasikan == "-" ) || (tomboluntukdioperasikan == "*") || (tomboluntukdioperasikan == "/"))
            {
                if (check)
                {
                    check = false;
                    txtResult.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txtResult.Text == "0")
                txtResult.Text = b.Text;

            else
                txtResult.Text += b.Text;
        }

        private void operasi(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(txtResult.Text);
            tomboluntukdioperasikan = b.Text;
            txtResult.Text += b.Text;
            check = true;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }

        private void Btnsamadengan_Click(object sender, EventArgs e)
        {
            try
            {
                switch(tomboluntukdioperasikan)
                {
                    case "+":
                        txtResult.Text = (value + double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-":
                        txtResult.Text = (value - double.Parse(txtResult.Text)).ToString();
                        break;
                    case "*":
                        txtResult.Text = (value * double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (value / double.Parse(txtResult.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox . Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
