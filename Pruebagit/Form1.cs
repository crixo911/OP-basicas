using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebagit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txtNum1.Text);
            Double num2 = Convert.ToDouble(txtNum2.Text);
            Double res=0;
            res = num1 + num2;
            txtResul.Text = Convert.ToString(res);
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txtNum1.Text);
            Double num2 = Convert.ToDouble(txtNum2.Text);
            Double res = 0;
            res = num1 - num2;
            txtResul.Text = Convert.ToString(res);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txtNum1.Text);
            Double num2 = Convert.ToDouble(txtNum2.Text);
            Double res = 0;
            res = num1 * num2;
            txtResul.Text = Convert.ToString(res);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txtNum1.Text);
            if (Convert.ToDouble(txtNum2.Text) == 0)
            {
                txtNum2.Text = "no se puede operar para cero";
            }
            else
            {
                Double num2 = Convert.ToDouble(txtNum2.Text);
                Double res = 0;
                res = num1 / num2;
                txtResul.Text = Convert.ToString(res);
            }
        }
        }
}
