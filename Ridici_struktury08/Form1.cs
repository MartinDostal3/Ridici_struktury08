using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ridici_struktury08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    string radek = textBox1.Lines[i];
                   
                    for (int j = 0; j < radek.Length; j++)
                    {
                        radek = char.ToUpper(radek[0]) + radek.Substring(1);
                        textBox1.Text = radek;
                    }
                    
                   
                     

                }
             
            }

            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    string radek = textBox1.Lines[i];
                    for (int j = 0; j < radek.Length; j++)
                    {
                        if (!radek.EndsWith("."))
                        {
                            radek = radek.Insert(radek[j - 1], ".");
                    }
                    }

                   



                }
            }
        }
    }
}
