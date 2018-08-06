using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 表白信
{
    public partial class Form1 : Form
    {
        bool close = false, move = true;
        int time = 10;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = 表白信.Properties.Resources._1;
            label2.Text = "能做我的女朋友吗？⁄(⁄ ⁄•⁄ω⁄•⁄ ⁄)⁄";
            close = false;move = false;
            time = 10;
            a = 0;
            timer1.Start();
            button2.Text = "不同意(" + time.ToString() + ")";
            button3.Visible = false;
            button2.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
            {
                if (MessageBox.Show("你要这么狠心离开我吗？Σ(っ °Д °;)っ", "拒绝回答", MessageBoxButtons.OKCancel) == DialogResult.OK)

                {
                    if(a >= 3)
                    {
                        MessageBox.Show("(°Д°≡°Д°)为什么这么对我.....");
                        pictureBox1.BackgroundImage = 表白信.Properties.Resources._3;
                    }
                    else
                    {
                        MessageBox.Show("<(￣3￣)>哼！,你走不了");
                        a++;
                    }
                    e.Cancel = true;

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "媳妇，爱你，么么哒(ฅ>ω<*ฅ)";
            pictureBox1.BackgroundImage = 表白信.Properties.Resources._2;
            close = true;
            move = false;
            button2.Visible = false;
            timer1.Stop();
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (move == false && close == true)
            {
                Application.Exit();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (move == true&& close == false)
            {
                int x = this.Width - button2.Width;
                int y = this.Height - button2.Height;
                Random r = new Random();
                button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (move == true && close == false)
            {
                MessageBox.Show("你是按不到我的¦•ˇ₃ˇ•｡)");
                int x = this.Width - button2.Width;
                int y = this.Height - button2.Height;
                Random r = new Random();
                button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (--time == 0)
            {
                timer1.Stop();
                move = true;
                button2.Enabled = true;
                button2.Text = "不同意";
            }
            else
            {
                button2.Text = "不同意(" + time.ToString() + ")";
            }
        }
    }
}
