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
            linkLabel_remember.Visible = true;
           
            //1234567890
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == false & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);
                
                for(int i = 0; i<len_pas; i++)
                {
                    int value = random.Next(0, 9);
                    textBox_password.Text += value.ToString();

                }
            }
            //ABC...
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == false & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                for (int i = 0; i < len_pas; i++)
                {
                    char value = (char)random.Next(65, 90);
                    textBox_password.Text += value.ToString();

                }
            }

            //abc...
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == true & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                for (int i = 0; i < len_pas; i++)
                {
                    char value = (char)random.Next(97, 122);
                    textBox_password.Text += value.ToString();

                }
            }

            //@#$%
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == false & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                for (int i = 0; i < len_pas; i++)
                {
                    char value = (char)random.Next(33, 46);
                    textBox_password.Text += value.ToString();

                }
            }

            //all
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == true & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789!@#$%^&*(){}[]?><";
                string result = "";

                int all_symb_length = all_symb.Length;

                for(int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;

            }

            //abc+ABC
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == true & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }

            //1234567890 + abc
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == true & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "qwertyupasdfghjklzxcvbnm123456789";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }

            //1234567890 + ABC
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == false & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "QWERTYUIOPASDFGHJKLZXCVBNM123456789";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }


            //1234567890 + symb
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == false & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "!@#$%^&*?/1234567890";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }



            //ABC + symb
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == false & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "!@#$%^&*?/QWERTYUIPASDFGHJKLZXCVBNM";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }


            //abc + symb
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == true & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "!@#$%^&*?/qwertyupasdfghjklzxcvbnm";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }


            //abc + ABC + 123
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == true & checkBox_symbols.Checked == false)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }

            //ABC + abc + symb
            if (checkBox_123.Checked == false & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == true & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "QWERTYUPASDFGHJKZXCVBNMqwertyupasdfghjkzxcvbnm!@#$%^&*";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }

            //123 + abc + symb
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == false & checkBox_abc.Checked == true & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "23456789qwertyuopasdfghjkzxcvbnm!@#$%^&*?";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }

            //ABC + 123 + symb
            if (checkBox_123.Checked == true & checkBox_high_ABC.Checked == true & checkBox_abc.Checked == false & checkBox_symbols.Checked == true)
            {
                int len_pas = int.Parse(label_length_of_password.Text);

                string all_symb = "QWERTYUPASDFGHJKZXCVBNM23456789!@#$%^&*";
                string result = "";

                int all_symb_length = all_symb.Length;

                for (int i = 0; i < len_pas; i++)
                {
                    result += all_symb[random.Next(all_symb_length)];
                }

                textBox_password.Text = result;
            }
            


        }

        private void pictureBox_copy_Click(object sender, EventArgs e)
        {
            textBox_password.Copy();
        }

        private void linkLabel_remember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Write($"\n {textBox_password.Text} ");
        }

        private void linkLabel_remember_Click(object sender, EventArgs e)
        {
            Program.Write($"\n {textBox_password.Text} ");
        }
    }
}
