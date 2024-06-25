using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs p)
        {

            Button[,] button1 = new Button[5, 5];

            int top = 30;
            int left = 30;

            Random rnd = new Random();
            int a = rnd.Next(1, 20);
            int b = rnd.Next(1, 20);
            int c = rnd.Next(1, 20);
            int d = rnd.Next(1, 20);
            int e = rnd.Next(1, 20);
            int f = rnd.Next(1, 20);
            int g = rnd.Next(1, 20);
            int h = rnd.Next(1, 20);


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char sayı = (char)rnd.Next('a', 'h' + 1);
                    button1[i, j] = new Button();
                    button1[i, j].Left = left;
                    button1[i, j].Top = top;
                    button1[i, j].Width = 150;
                    button1[i, j].Height = 70;
                    button1[i, j].BackColor = Color.Black;
                    this.Controls.Add(button1[i, j]);
                    left += 300;
                    button1[i, j].Click += new EventHandler((ü, ı) =>
                    {
                        Button tiklananDugme = ü as Button;
                        tiklananDugme.BackColor = Color.White;
                        switch (sayı)
                        {
                            case 'a':
                                tiklananDugme.Text = a.ToString();
                                break;
                            case 'b':
                                tiklananDugme.Text = b.ToString();
                                break;
                            case 'c':
                                tiklananDugme.Text = c.ToString();
                                break;
                            case 'd':
                                tiklananDugme.Text = d.ToString();
                                break;
                            case 'f':
                                tiklananDugme.Text = f.ToString();
                                break;
                            case 'e':
                                tiklananDugme.Text = e.ToString();
                                break;
                            case 'g':
                                tiklananDugme.Text = g.ToString();
                                break;
                            case 'h':
                                tiklananDugme.Text = h.ToString();
                                break;
                        }

                    });


                }
                top += 150;
                left = 30;
            }
        }



    }
}
