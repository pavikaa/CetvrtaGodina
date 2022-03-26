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
    public partial class Form1 : Form
    {
        int btn1Counter = 0;
        int btn2Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            btn1Counter++;
            lblBtn1.Text = "Tipka 1 pritisnuta je : " + btn1Counter + " puta.";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2Counter++;
            lblBtn2.Text = "Tipka 2 pritisnuta je : " + btn2Counter + " puta.";
        }

        private void lblBtn1_TextChanged(object sender, EventArgs e)
        {
            lblLastClicked.Text = "Zadnja pritisnuta tipka je: Tipka 1.";
        }

        private void lblBtn2_TextChanged(object sender, EventArgs e)
        {
            lblLastClicked.Text = "Zadnja pritisnuta tipka je: Tipka 2.";
        }
    }
}
