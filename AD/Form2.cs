using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void logi_Click(object sender, EventArgs e)
        {
            
            
            Form1 kaasa = new Form1();
            kaasa.Owner = this;
            kaasa.ShowDialog();

        }

        private void reg_Click(object sender, EventArgs e)
        {
            Form3 reg = new Form3();
            reg.Owner = this;
            reg.ShowDialog();
        }
    }
}
