using System;
using System.Collections;
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
    public partial class 作業6 : Form
    {
        public 作業6()
        {
            InitializeComponent();
        }
        public studentgrand stg = new studentgrand();
        public testgrand grand = new testgrand();
        public HW6 go = new HW6();
        ArrayList hw6 = new ArrayList();
        HW6 C;
        void ShowScore()
        {

                scorename.Text = $"{"姓名".PadRight(3)}{"數學".PadRight(3)}{"英文".PadRight(3)}{"國文".PadRight(3)}{"總分".PadRight(3)}{"平均".PadRight(3)}{"最低分".PadRight(3)}{"最高分".PadRight(3)}";
                kiscore.Text = "";
                for (int i = 0; i < hw6.Count; i++)
                {
                    //    s+=s+string.Format("{0,6}{1,6}{2,6}", ((HW6)hw6[i]).Name, ((HW6)hw6[i]).Math, ((HW6)hw6[i]).EN)+ string.Format("{0,6}{1,6}{2,6:N1}", ((HW6)hw6[i]).CH, ((HW6)hw6[i]).All, ((HW6)hw6[i]).Avg)+ string.Format("{0,6}{1,6}\n", ((HW6)hw6[i]).Minscore + ((HW6)hw6[i]).Min, ((HW6)hw6[i]).Maxscore + ((HW6)hw6[i]).MAx);
                    kiscore.Text += $"{((HW6)hw6[i]).Name.PadRight(5)}{(((HW6)hw6[i]).Math)}{"".PadRight(5)}{((HW6)hw6[i]).EN}{"".PadRight(5)}{((HW6)hw6[i]).CH}{"".PadRight(5)} {((HW6)hw6[i]).All}{"".PadRight(5)} {((HW6)hw6[i]).Avg}{"".PadRight(5)} {((HW6)hw6[i]).Minscore}{((HW6)hw6[i]).Min}{((HW6)hw6[i]).Maxscore}{((HW6)hw6[i]).MAx}\n";
                }



        }
        private void button3_Click(object sender, EventArgs e)
        {
            hw6.RemoveAt(0);

            ShowScore();
        }

        private void 加入資料_Click(object sender, EventArgs e)
        {

            if (Nametx.Text == "")
            {
                MessageBox.Show("沒有姓名", "注意", MessageBoxButtons.OK);
                Nametx.Clear();
                Nametx.Focus();
            }
            else if (Mathtx.Text == "")
            {
                MessageBox.Show("尚未輸入分數", "注意", MessageBoxButtons.OK);
                Mathtx.Clear();
                Mathtx.Focus();
            }
            else if (Chtx.Text == "")
            {
                MessageBox.Show("尚未輸入分數", "注意", MessageBoxButtons.OK);
                Chtx.Clear();
                Chtx.Focus();
            }
            else if (Entx.Text != "")

            {
                C.Name = Nametx.Text;
                C.CH = int.Parse(Chtx.Text);
                C.EN = int.Parse(Entx.Text);
                C.Math = int.Parse(Mathtx.Text);
                C.All = (C.Math + C.EN + C.CH);
                C.Avg = Math.Floor((C.All) / 3);
                int[] x = { C.CH, C.EN, C.Math };
                string[] y = { "國文", "英文", "數學" };
                C.MAx = x[0];
                C.Min = x[0];
                C.Maxscore = y[0];
                C.Minscore = y[0];
                for (int r = 0; r < x.Length; r++)
                {
                    if (C.MAx < x[r])
                    {
                        C.MAx = x[r];
                        C.Maxscore = y[r];
                    }
                    if (C.Min > x[r])
                    {
                        C.Min = x[r];
                        C.Minscore = y[r];
                    }

                }
            }
            else
            {
                MessageBox.Show("尚未輸入分數", "注意", MessageBoxButtons.OK);
                Entx.Clear();
                Entx.Focus();
                
                Entx.Focus();
            }

            hw6.Add(C);
                ShowScore();


                移除資料.Enabled = true;
                全清.Enabled = true;
            各科計算.Enabled = true;
            
        }
 


        private void 插入資料_Click(object sender, EventArgs e)
        {
            C.Name = Nametx.Text;
            C.CH = int.Parse(Chtx.Text);
            C.EN = int.Parse(Entx.Text);
            C.Math = int.Parse(Mathtx.Text);
            C.All = (C.Math + C.EN + C.CH);
            C.Avg = Math.Floor((C.All) / 3);
            int[] x = { C.CH, C.EN, C.Math };
            string[] y = { "國文", "英文", "數學" };
            C.MAx = x[0];
            C.Min = x[0];
            C.Maxscore = y[0];
            C.Minscore = y[0];
            for (int r = 0; r < x.Length; r++)
            {
                if (C.MAx < x[r])
                {
                    C.MAx = x[r];
                    C.Maxscore = y[r];
                }
                if (C.Min > x[r])
                {
                    C.Min = x[r];
                    C.Minscore = y[r];
                }

            }





            hw6.Insert(0,C);
            移除資料.Enabled = true;
            全清.Enabled = true;
            ShowScore();
            各科計算.Enabled = true;

        }

        private void 全清_Click(object sender, EventArgs e)
        {
            hw6.Clear();
            成績統計.Text = "";
            ShowScore();
            全清.Enabled = false;
            移除資料.Enabled = false;
            加入資料.Enabled = true;
            插入資料.Enabled = true;
        }

        private void 搜尋_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TX1.Text);
            int y = int.Parse(TX2.Text);
            kiscore.Text = string.Empty;
            for (int i = 0; i < hw6.Count; i++)
            {
                if ((x > ((HW6)hw6[i]).CH? false : y >= ((HW6)hw6[i]).CH))
                {
                    kiscore.Text += $"{((HW6)hw6[i]).Name.PadRight(5)}{(((HW6)hw6[i]).Math)}{"".PadRight(5)}{((HW6)hw6[i]).EN}{"".PadRight(5)}{((HW6)hw6[i]).CH}{"".PadRight(5)} {((HW6)hw6[i]).All}{"".PadRight(5)} {((HW6)hw6[i]).Avg}{"".PadRight(5)} {((HW6)hw6[i]).Minscore}{((HW6)hw6[i]).Min}{((HW6)hw6[i]).Maxscore}{((HW6)hw6[i]).MAx}\n";
                }
            }
            各科計算.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            C.allch = 0;
            C.allen = 0;
            C.allmath = 0;
            C.MaxCn = 0;
            C.MaxEn = 0;
            C.MaxMath = 0;
            C.MinCn = 999;
            C.MinEn = 999;
            C.MinMath = 999;
            for (int i = 0; i < hw6.Count; i++)
            {
                C.allch += ((HW6)hw6[i]).CH;
                C.allen += ((HW6)hw6[i]).EN;
                C.allmath += ((HW6)hw6[i]).Math;
            }
            for (int r = 0; r < hw6.Count; r++)
            {
                if (((HW6)hw6[r]).CH > C.MaxCn)
                {
                    C.MaxCn = ((HW6)hw6[r]).CH;
                }
                if (((HW6)hw6[r]).EN > C.MaxEn)
                {
                    C.MaxEn = ((HW6)hw6[r]).EN;
                }
                if (((HW6)hw6[r]).Math > C.MaxMath)
                {
                    C.MaxMath = ((HW6)hw6[r]).Math;
                }
                if (((HW6)hw6[r]).CH < C.MinCn)
                {
                    C.MinCn = ((HW6)hw6[r]).CH;
                }
                if (((HW6)hw6[r]).Math < C.MinMath)
                {
                    C.MinMath = ((HW6)hw6[r]).Math;
                }
                if (((HW6)hw6[r]).EN < C.MinEn)
                {
                    
                    C.MinEn = ((HW6)hw6[r]).EN;
                }
            }
            C.avecn = Math.Round((C.allch / hw6.Count), 1);
            C.aveen = Math.Round((C.allen / hw6.Count), 1);
            C.avemath = Math.Round((C.allmath / hw6.Count), 1);
            成績統計.Text = string.Concat(string.Format("總分{0,6} {1,6}{2,6}\n", C.allmath, C.allen, C.allch), string.Format("平均{0,8:N1} {1,6:N1}{2,6:N1}\n", C.avemath, C.aveen, C.avecn), string.Format("最高分{0,6}{1,6}{2,6}\n", C.MaxMath, C.MaxEn, C.MaxCn), string.Format("最低分{0,6}{1,6}{2,6}", C.MinMath, C.MinEn, C.MinCn));

            加入資料.Enabled = false;
            插入資料.Enabled = false;
            移除資料.Enabled = false;
            各科計算.Enabled = false;
        }
    }
}
