using System;
using System.Windows.Forms;

namespace examplewintoconsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
    }
}
