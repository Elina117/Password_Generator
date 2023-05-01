using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            checkBox_abc.Checked = true;
            checkBox_high_ABC.Checked = true;
            checkBox_symbols.Checked = true;
            checkBox_123.Checked = true;
        }

       

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            string len = label_length_of_password.Text;
            int len_num = int.Parse(len);

            len_num = len_num + 2;
            if (len_num > 16)
            {
                len_num = 16;
            }

            string finish = len_num.ToString();

            label_length_of_password.Text = finish;

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string len = label_length_of_password.Text;
            int len_num = int.Parse(len);

            len_num = len_num - 2;
            if (len_num < 0)
            {
                len_num = 0;
            }

            string finish = len_num.ToString();

            label_length_of_password.Text = finish;
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            textBox_password.Clear();
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == false & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);
                
                for(int i = 0; i<len_pas; i++)
                {
                    int value = random.Next(0, 9);
                    textBox_password.Text += value.ToString();

                }
            }

            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == false & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                for (int i = 0; i < len_pas; i++)
                {
                    char value = (char)random.Next(65, 90);
                    textBox_password.Text += value.ToString();

                }
            }

            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == true & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                for (int i = 0; i < len_pas; i++)
                {
                    char value = (char)random.Next(97, 122);
                    textBox_password.Text += value.ToString();

                }
            }

            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == false & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                for (int i = 0; i < len_pas; i++)
                {
                    char value = (char)random.Next(33, 46);
                    textBox_password.Text += value.ToString();

                }
            }

            
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == true & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789!@#$%^&*(){}[]?><";
                string result = "";

                for(int i = 0; i < len_pas; i++)
                {

                }


            }

        }

        public void Shuffle(char[] array)
        {
            char temp;
            for (int i = array.Length - 1; i >= 1; i--)
            {
                char j = (char)random.Next(i + 1);

                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
            
        }

    }
}
