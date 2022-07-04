using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp作業集
{
    public partial class 作業10 : Form
    {
        public 作業10()
        {
            InitializeComponent();
        }
        int i = 0   ;
        void reset()
        {
            foreach (Button x in game.Controls)
            {
                x.Text = "";
                x.Enabled = true;
            }
        }
        void end()
        {

            if ((左下.Text == "X" && 中左.Text == "X" && 左上.Text == "X") ||
                (左上.Text == "X" && 中上.Text == "X" && 右上.Text == "X") ||
                (左上.Text == "X" && 中.Text == "X" && 右下.Text == "X") ||
                (中左.Text == "X" && 中.Text == "X" && 中右.Text == "X") ||
                (右上.Text == "X" && 中.Text == "X" && 左下.Text == "X") ||
                (右上.Text == "X" && 中右.Text == "X" && 右下.Text == "X") ||
                (中上.Text == "X" && 中.Text == "X" && 中下.Text == "X") ||
                (左下.Text == "X" && 中下.Text == "X" && 右下.Text == "X"))
            {
                MessageBox.Show("叉叉贏了");
                左上.Enabled = false; 中左.Enabled = false; 左下.Enabled = false;
                中上.Enabled = false; 中.Enabled = false; 中下.Enabled = false;
                右上.Enabled = false; 中右.Enabled = false; 右下.Enabled = false;
            }
            else if ((左下.Text == "O" && 中左.Text == "O" && 左上.Text == "O") ||
                (左上.Text == "O" && 中上.Text == "O" && 右上.Text == "O") ||
                (左上.Text == "O" && 中.Text == "O" && 右下.Text == "O") ||
                (中左.Text == "O" && 中.Text == "O" && 中右.Text == "O") ||
                (右上.Text == "O" && 中.Text == "O" && 左下.Text == "O") ||
                (右上.Text == "O" && 中右.Text == "O" && 右下.Text == "O") ||
                (中上.Text == "O" && 中.Text == "O" && 中下.Text == "O") ||
                (左下.Text == "O" && 中下.Text == "O" && 右下.Text == "O"))
            {
                MessageBox.Show("圈圈贏了");
                左上.Enabled = false; 中左.Enabled = false; 左下.Enabled = false;
                中上.Enabled = false; 中.Enabled = false; 中下.Enabled = false;
                右上.Enabled = false; 中右.Enabled = false; 右下.Enabled = false;
            }
            else if (左上.Enabled == false &&中左.Enabled == false&& 左下.Enabled == false&&
                中上.Enabled == false&& 中.Enabled == false&& 中下.Enabled == false&&
                右上.Enabled == false&& 中右.Enabled == false&& 右下.Enabled == false)
            {
                MessageBox.Show("平手呢");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    左上.Text = "O";
                }
                else
                {
                    左上.Text = "X";
                }
            左上.Enabled = false;
            end();
        }

        private void 中上_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    中上.Text = "O";
                }
                else
                {
                    中上.Text = "X";
                }
            中上.Enabled = false;
            end();
        }

        private void 右上_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    右上.Text = "O";
                }
                else
                {
                    右上.Text = "X";
                }
            右上.Enabled = false;
            end();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    中左.Text = "O";
                }
                else
                {
                    中左.Text = "X";
                }
            中左.Enabled = false;
            end();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    左下.Text = "O";
                }
                else
                {
                    左下.Text = "X";
                }
            左下.Enabled = false;
            end();
        }

        private void 中_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    中.Text = "O";
                }
                else
                {
                    中.Text = "X";
                }
            中.Enabled = false;
            end();
        }

        private void 中右_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    中右.Text = "O";
                }
                else
                {
                    中右.Text= "X";
                }
            中右.Enabled = false;
            end();
        }

        private void 中下_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    中下.Text = "O";
                }
                else
                {
                    中下.Text= "X";
                }
            中下.Enabled = false;
            end();
        }

        private void 右下_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
                if (x == 0)
                {
                    右下.Text = "O";
                }
                else
                {
                    右下.Text= "X";
                }
            右下.Enabled = false;
            end();
        }

        private void 作業10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reset();
        }
    }
}
