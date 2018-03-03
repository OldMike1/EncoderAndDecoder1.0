using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncoderAndDecoder1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', ',', '.', '!', '?', ':', ';', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private void button1_Click(object sender, EventArgs e)
        {
            string encoder = "";
            string text = textBox1.Text;
            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (text[i] == letters[j])
                    {
                        encoder = encoder + (j + 10).ToString();
                    }
                }
            }
            textBox2.Text = encoder;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            string decoder = "";
            for (int i = 0; i < textBox1.Text.Length; i += 2)
            {
                string bukva = textBox1.Text[i].ToString() + textBox1.Text[i + 1].ToString();
                decoder += letters[int.Parse(bukva) - 10];
            }
            Console.WriteLine(decoder);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
