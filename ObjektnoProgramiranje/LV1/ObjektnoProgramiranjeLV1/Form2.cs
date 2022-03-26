using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjektnoProgramiranjeLV1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            float D = b * b - 4 * a * c;
            if (D >= 0)
                { 
            lblX1.Text = "x1 : " + Math.Round(((-b + Math.Sqrt(D)) / (2 * a)),3).ToString();
            lblX2.Text = "x2 : " + Math.Round(((-b - Math.Sqrt(D)) / (2 * a)),3).ToString();
            }
            if (D < 0)
            {
                lblX1.Text = "x1 : " + Math.Round((-b / (2 * a)), 3).ToString() + " + " + Math.Round((Math.Sqrt(-D) / (2 * a)), 3).ToString() + " i";
                lblX2.Text = "x2 : " + Math.Round((-b / (2 * a)), 3).ToString() + " + " + Math.Round(-(Math.Sqrt(-D) / (2 * a)), 3).ToString() + " i";
            }
        }

    }
}
