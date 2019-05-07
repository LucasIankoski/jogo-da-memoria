using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jogoMemoria
{
    public partial class Form1 : Form
    {

        int[,] blocos;
        Random rand = new Random();
        int click;
        int m, n;
        int x, y;
        int cron;
        int fim;
        Button btn1, btn2;

        private void novo()
        {
            int elem = 0;
            blocos = new int[4, 8];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    blocos[i, j] = (elem++) / 2;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int m = rand.Next(0, 4);
                    int n = rand.Next(0, 8);

                    int tmp = blocos[i, j];
                    blocos[i, j] = blocos[m, n];
                    blocos[m, n] = tmp;
                }
            }


            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";
            button27.Text = "";
            button28.Text = "";
            button29.Text = "";
            button30.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;

            click = 0;

            timer1.Stop();
            timer2.Stop();
            fim = 0;
            label1.Text = "0:00.0";
        }

        private void renderiza(Button btn, int i, int j)
        {
            int valor = blocos[i, j];
            if (valor <= 9)
            {
                btn.Text = blocos[i, j].ToString();
            }
            else
            {
                btn.Text = ((char)((valor - 10) + ((int)'A'))).ToString();
            }
        }

        private void escolha(Button btn, int i, int j)
        {
            if (click == 0 || click == 3 || click == 2)
            {
                if (click == 2)
                {
                    timer2_Tick(null, null);
                    cron += 30;
                }
                renderiza(btn, i, j);
                m = i;
                n = j;
                btn1 = btn;
                if (click == 0)
                {
                    cron = 0;
                    timer1.Start();
                }
                click = 1;
            }
            else if (click == 1 && btn != btn1)
            {
                renderiza(btn, i, j);
                x = i;
                y = j;
                btn2 = btn;
                timer2.Start();
                click = 2;
            }
        }

        public Form1()
        {
            InitializeComponent();
            novo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 7);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 0);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 3);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 4);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 5);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 6);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 0);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 1);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 3);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 4);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 5);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 6);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 7);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tmp = ++cron;
            label1.Text = (tmp / (60 * 10)).ToString();
            tmp -= (tmp / (60 * 10) * (60 * 10));
            label1.Text += ":";
            if (tmp < 100)
            {
                label1.Text += "0";
            }
            label1.Text += (tmp / 10).ToString();
            label1.Text += ".";
            tmp -= (tmp / 10) * 10;
            label1.Text += tmp.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();



            if (blocos[m, n] == blocos[x, y])
            {
                btn1.Hide(); //.Visible = false;
                btn2.Hide();
                ++fim;
                if (fim == 16)
                {
                    timer1.Stop();
                    label2.Text = "Parabéns, você terminou o jogo!";

                }
            }
            else
            {
                btn1.Text = "";
                btn2.Text = "";
            }
            click = 3;           
        }



    }
}




