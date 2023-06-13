using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
            label6.Text = "";
        }


        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rt = 0;
            string erro = "";
            try
            {
                if (radioButton3.Checked == true)
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox3.Text);
                     rt = a - b;
                   
                }
            }
            catch (Exception ex)
            {
                erro= "Filho você fez algo de errado";
            }
            try
            {
                if (radioButton2.Checked == true)
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox3.Text);
                    rt = a + b;
                }
            }
            catch (Exception ex)
            {
                erro = "Filho você fez algo de errado";
            }
            try
            {
                if (radioButton1.Checked)
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox3.Text);
                    rt = a / b;
                }

            }
            catch (Exception ex)
            {
                erro = "Filho você fez algo de errado";
            }
            finally
            {
                Console.WriteLine("Obrigado por usar!!!");
            }
            Resultado m = new Resultado();
            label4.Text = Convert.ToString(rt); 
            label6.Text = Convert.ToString(erro);
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            
        }
    }
}
