using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_zad_2
{
    public partial class Form1 : Form
    {
        int newSize;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    newSize = 12;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize);
                }
                if (radioButton2.Checked == true)
                {
                    newSize = 14;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize);
                }
                if (radioButton3.Checked == true)
                {
                    newSize = 16;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize);
                }
            }
            else
            {
                MessageBox.Show("Wybierz Wielkosc Tekstu !", "Uwaga");
            }
            if ((checkBox1.Checked == true) || (checkBox2.Checked == true) || (checkBox3.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold | FontStyle.Italic);
                }
                else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold | FontStyle.Underline);
                }
                else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (checkBox1.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold);
                }
                else if (checkBox2.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Italic);
                }
                else if (checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Underline);
                }
            }
            if (radioButton4.Checked==true || radioButton5.Checked==true || radioButton6.Checked == true)
            {
                if (radioButton4.Checked == true)
                {
                    textBox1.ForeColor = Color.Red;
                }
                if (radioButton5.Checked == true)
                {
                    textBox1.ForeColor = Color.Blue;
                }
                if (radioButton6.Checked == true)
                {
                    textBox1.ForeColor = Color.Orange;
                }
            }
            else
            {
                MessageBox.Show("Wybierz Kolor Tekstu !","Uwaga");
            }
        }
    }
}
/*
 if((checkBox1.Checked == true) || (checkBox1.Checked == true) || (checkBox1.Checked == true))
            {
                if (checkBox1.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                }
                if (checkBox2.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                }
                if (checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                }
            }
 */