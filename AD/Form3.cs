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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sise_Click(object sender, EventArgs e)
        {
            Form1 kaasa = new Form1();
            kaasa.Owner = this;
            kaasa.ShowDialog();
        }
    }
}
