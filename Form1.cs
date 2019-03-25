using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nowchoice = 0;
        bool find = false;
        int displaytime = 500;
        int playtime = 60;
        int pair = 8;
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 0;
                find = true;
            }
            else
            {
                Compare(pictureBox1, ref button1);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 1;
                find = true;
            }
            else
            {
                Compare(pictureBox2, ref button2);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 2;
                find = true;
            }
            else
            {
                Compare(pictureBox3, ref button3);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 3;
                find = true;
            }
            else
            {
                Compare(pictureBox4, ref button4);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 4;
                find = true;
            }
            else
            {
                Compare(pictureBox5, ref button5);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 5;
                find = true;
            }
            else
            {
                Compare(pictureBox6, ref button6);
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 6;
                find = true;
            }
            else
            {
                Compare(pictureBox7, ref button7);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 7;
                find = true;
            }
            else
            {
                Compare(pictureBox8, ref button8);
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 8;
                find = true;
            }
            else
            {
                Compare(pictureBox9, ref button9);
            }

        }

        private async void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 9;
                find = true;
            }
            else
            {
                Compare(pictureBox10, ref button10);
            }
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 10;
                find = true;
            }
            else
            {
                Compare(pictureBox11, ref button11);
            }
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 11;
                find = true;
            }
            else
            {
                Compare(pictureBox12, ref button12);
            }
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 12;
                find = true;
            }
            else
            {
                Compare(pictureBox13, ref button13);
            }
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 13;
                find = true;
            }
            else
            {
                Compare(pictureBox14, ref button14);
            }
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            await Task.Delay(displaytime);

            if (find == false)
            {
                nowchoice = 14;
                find = true;
            }
            else
            {
                Compare(pictureBox15, ref button15);
            }
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            await Task.Delay(displaytime);
            if (find == false)
            {
                nowchoice = 15;
                find = true;
            }
            else
            {
                Compare(pictureBox16, ref button16);
            }
        }

        private void Compare(PictureBox pb, ref Button bt)
        {
            object[] pbgroup = {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4,
                pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                pictureBox9, pictureBox10, pictureBox11, pictureBox12,
                pictureBox13, pictureBox14, pictureBox15, pictureBox16 };
            object[] btgroup =
            {
                button1, button2, button3, button4,
                button5, button6, button7, button8,
                button9, button10, button11, button12,
                button13, button14, button15, button16
            };
            
            Bitmap firstImage = (Bitmap)pb.Image;
            Bitmap secondImage = (Bitmap)(((PictureBox)pbgroup[nowchoice]).Image);
            bool compare = true;
            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    if (!firstImage.GetPixel(x, y).Equals(secondImage.GetPixel(x, y)))
                    {
                        compare = false;
                        break;
                    }
                }
            }
            
            if (compare == true)
            {
                bt.Visible = false;
                find = false;
                MessageBox.Show("Good!");
            }
            else
            {
                bt.Visible = true;
                ((Button)btgroup[nowchoice]).Visible = true;
                find = false;
            }

            if (Count() % 2 == 1)
                pair = Count() / 2 + 1;
            else
                pair = Count() / 2;

            lblPair.Text = "剩餘牌組數: " + pair.ToString() + " 對";

            if (pair == 0)
            {
                pbWin.Visible = true;
                MessageBox.Show("再來一局吧!!!");
                Application.Restart();
            }
        }
        private int Count()
        {
            int count = 0;
            object[] bt = {
                button1, button2, button3, button4,
                button5, button6, button7, button8,
                button9, button10, button11, button12,
                button13, button14, button15, button16 };
            for (int i = 0; i < bt.Length; i++)
            {
                if (((Button)bt[i]).Visible == true)
                    count++;
            }
            return count;
        }
        private bool Check(int[] array, int c)
        {
            for (int i = 0; i < c; i++)
            {
                if (array[i] == array[c])
                    return false;
            }
            return true;
        }
        public void button17_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button17.Visible = false;
            lblTime.Visible = true;
            lblPair.Visible = true;
            object[] pb = {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4,
                pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                pictureBox9, pictureBox10, pictureBox11, pictureBox12,
                pictureBox13, pictureBox14, pictureBox15, pictureBox16 };

            pbStart.Visible = false;
            Random ran = new Random();
            int[] p = new int[16];
            int i = 0;
            while (i < 16)
            {
                p[i] = ran.Next(16);
                if (Check(p, i))
                    i++;
            }
            for (i = 0; i < pb.Length; i++)
            {
                ((PictureBox)pb[i]).Image = imageList1.Images[p[i]];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playtime == 0)
            {
                pbLose.Visible = true;
                timer1.Stop();
                MessageBox.Show("再來一局吧!!!");
                Application.Restart();
            }
            else if (pair != 0)
            {
                playtime--;
                lblTime.Text = "剩餘時間: " + playtime.ToString() + " 秒";
            }
        }
    }
}
