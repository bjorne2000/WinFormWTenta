using BackendWinFormTenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentaWinForm
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            this.Hide();
            formBokning bokning = new formBokning();
            bokning.ShowDialog();            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ChangeBokning frm = new ChangeBokning();
            frm.ShowDialog();
        }
    }
}
