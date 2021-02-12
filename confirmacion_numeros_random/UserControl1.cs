using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace confirmacion_numeros_random
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Random patata = new Random();

            int patatafrita = patata.Next(10);

            /* textBox1.Text = patatafrita.ToString();*/
            textBox1.Text = checkBox1.Text.Substring(7);
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }
    }
}