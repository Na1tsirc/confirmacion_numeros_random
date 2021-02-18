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

        public void button2_Click(object sender, EventArgs e)
        {
            Random patata = new Random();

            int patatafrita = patata.Next(10);
            textBox1.Text = patatafrita.ToString();
            /*textBox1.Text = checkBox1.Text.Substring(7);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String patata2 = textBox1.Text;
            if (radioButton1.Checked == true & patata2 == radioButton1.Text.Substring(7)) {
                MessageBox.Show("has acertado");                
            }
            else if (radioButton2.Checked == true & patata2 == radioButton2.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else if (radioButton3.Checked == true & patata2 == radioButton3.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else if (radioButton4.Checked == true & patata2 == radioButton4.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else if (radioButton5.Checked == true & patata2 == radioButton5.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else if (radioButton6.Checked == true & patata2 == radioButton6.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else if (radioButton7.Checked == true & patata2 == radioButton7.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }else if (radioButton8.Checked == true & patata2 == radioButton8.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }else if (radioButton9.Checked == true & patata2 == radioButton9.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else if (radioButton10.Checked == true & patata2 == radioButton10.Text.Substring(7))
            {
                MessageBox.Show("has acertado");
            }
            else 
            {
                if (PropiedadCreada != null && PropiedadCreada != "")
                {
                    MessageBox.Show(PropiedadCreada);
                }
                else
                {                    
                    MessageBox.Show("has fallado");
                }
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton1.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton3.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton4.Checked;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton5.Checked;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton6.Checked;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton7.Checked;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton8.Checked;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton9.Checked;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton10.Checked;
        }
    }
    
}