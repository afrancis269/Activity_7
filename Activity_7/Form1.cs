using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, i;
            double value;
            try
            {
                number = int.Parse(termTxb.Text);
                value = 0;
                for (i = 0; i < number; i++)
                {
                    value += ( 4 * Math.Pow(-1, i) ) / (i * 2 + 1) ;
                }
                resTxb.Text = string.Format("{0:#,0.000}", value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
