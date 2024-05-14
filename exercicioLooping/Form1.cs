using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioLooping
{
    public partial class frmLooping : Form
    {
        public frmLooping()
        {
            InitializeComponent();
        }
        double num, i, x;
        string result;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtNum.Text);

            i = num;

            do
            {
                x = num * (i - 1);
                num = x;
                result = String.Concat(txtResult.Text, "\r\n", x.ToString());
                txtResult.Text = result;
                i--;
            }

            while (i > 1);
            
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtNum.Text);

            for (i = num; i > 1; i--);
            {
                x = num * (i - 1);
                num = x;
                result = String.Concat(txtResult.Text, "\r\n", x.ToString());
                txtResult.Text = result;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {   

            num = Convert.ToDouble(txtNum.Text);
           
            i = num;

            while (i > 1)
            {
                x = num * (i-1);
                num = x;
                result = String.Concat(txtResult.Text, "\r\n", x.ToString());
                txtResult.Text = result;
                i--;
            }
        }
    }
}
