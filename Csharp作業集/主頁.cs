using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Csharp作業集
{
    public partial class 主頁 : Form
    {
        public 主頁()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 自我介紹_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            介紹 hw1 = new 介紹();
            hw1.TopLevel = false;
            hw1.Top = 0;
            hw1.Left = 0;
            框2.Panel2.Controls.Add(hw1);
            hw1.Show();
        }

        private void 框2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 點菜單_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            菜單 hw3 = new 菜單();
            hw3.TopLevel = false;
            hw3.Top = 0;
            hw3.Left = 0;
            框2.Panel2.Controls.Add(hw3);
            hw3.Show();
        }

        private void 貸款計算_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            貸款計算 hw2 = new 貸款計算();
            hw2.TopLevel = false;
            hw2.Top = 0;
            hw2.Left = 0;
            框2.Panel2.Controls.Add(hw2);
            hw2.Show();
                }

        private void 成績登入_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            成績統計01 hw4 = new 成績統計01();
            hw4.TopLevel = false;
            hw4.Top = 0;
            hw4.Left = 0;
            框2.Panel2.Controls.Add(hw4);
            hw4.Show();

        }

        private void 成績統計_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            成績統計2 hw5 = new 成績統計2();
            hw5.TopLevel = false;
            hw5.Top = 0;
            hw5.Left = 0;
            框2.Panel2.Controls.Add(hw5);
            hw5.Show();
        }

        private void 猜數字_Click(object sender, EventArgs e)
        {

        }

        private void 成績搜尋_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            作業6 hw6 = new 作業6();
            hw6.TopLevel = false;
            hw6.Top = 0;
            hw6.Left = 0;
            框2.Panel2.Controls.Add(hw6);
            hw6.Show();
        }

        private void 計算機_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            作業8 hw8 = new 作業8();
            hw8.TopLevel = false;
            hw8.Top = 0;
            hw8.Left = 0;
            框2.Panel2.Controls.Add(hw8);
            hw8.Show();
        }

        private void OXgame_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            作業10 hw10 = new 作業10();
            hw10.TopLevel = false;
            hw10.Top = 0;
            hw10.Left = 0;
            框2.Panel2.Controls.Add(hw10);
            hw10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            框2.Panel2.Controls.Clear();
            作業9 hw9 = new 作業9();
            hw9.TopLevel = false;
            hw9.Top = 0;
            hw9.Left = 0;
            框2.Panel2.Controls.Add(hw9);
            hw9.Show();
        }
    }
}
