using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp作業集
{
    public partial class 成績統計2 : Form
    {
        int im = 0;
        public studentgrand stg = new studentgrand();
        public testgrand[] grand = new testgrand[100];
                    Random R = new Random();    
        
        public 成績統計2()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            總結.Enabled = true;

            if(nametx.Text=="")
            {
                MessageBox.Show("沒有姓名","注意", MessageBoxButtons.OK);
            }
            else if(mathtx.Text=="")
            {
                MessageBox.Show("尚未輸入分數", "注意",MessageBoxButtons.OK);
            }
            else if(chtx.Text=="")
            {
                MessageBox.Show("尚未輸入分數", "注意", MessageBoxButtons.OK);
            }
            else if(entx.Text!="")
            
            {
                grand[im].Name =nametx.Text;
                grand[im].Math = int.Parse(mathtx.Text);
                grand[im].EN = int.Parse(entx.Text);
                grand[im].CH = int.Parse(chtx.Text);
                grand[im].All = (grand[im].Math + grand[im].EN + grand[im].CH);
                grand[im].Avg = (grand[im].All) / 3;
                int[] x = {grand[im].CH,grand[im].EN,grand[im].Math };
                string[] y = { "國文", "英文", "數學" };
                grand[im].MAx = x[0];
                grand[im].Min = x[0];
                grand[im].Maxscore = y[0];
                grand[im].Minscore = y[0];
                for(int r = 0; r < x.Length; r++)
                {
                    if (grand[im].MAx < x[r])
                    {
                        grand[im].MAx = x[r];
                        grand[im].Maxscore = y[r];
                    }
                    if(grand[im].Min>x[r])
                    {
                        grand[im].Min = x[r];
                        grand[im].Minscore = y[r];
                    }

                }
                if (im == 50)
                {
                    MessageBox.Show("資料過載,請刪除多餘資料", "告知", MessageBoxButtons.OK);
                    單一學生.Enabled = false;
                    隨機20.Enabled = false;
                    隨機加入.Enabled = false;

                }
                scorename.Text = $"{"姓名".PadRight(3)}{"數學".PadRight(3)}{"英文".PadRight(3)}{"國文".PadRight(3)}{"總分".PadRight(3)}{"平均".PadRight(3)}{"最低分".PadRight(3)}{"最高分".PadRight(3)}";

                Label Score = score;
                Score.Text = string.Concat(Score.Text, string.Format("{0,6}{1,6}{2,6}", grand[im].Name,grand[im].Math,grand[im].EN), string.Format("{0,6}{1,6}{2,6:N1}", grand[im].CH,grand[im].All, grand[im].Avg), string.Format("{0,6}{1,6}\n",grand[im].Minscore+ grand[im].Min,grand[im].Maxscore+ grand[im].MAx)); 
                im++;
               
            }
            else
            {
                MessageBox.Show("尚未輸入分數", "注意", MessageBoxButtons.OK);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            im = 0;
            for (int i=0; i < im; i++)
            {
                grand[i].CH = 0;
                grand[i].EN = 0;
                grand[i].Math = 0;
                grand[i].Avg = 0;
                grand[i].All = 0;
                stg.allch = 0;
                stg.allen = 0;
                stg.allmath = 0;
                stg.avecn = 0;
                stg.aveen = 0;
                stg.allmath = 0;
                stg.MaxCn = 0;
                stg.MaxEn = 0;
                stg.MaxMath = 0;
                stg.MinCn = 0;
                stg.MinEn = 0;
                stg.MinMath = 0;
            }

            score.Text = "";

            allscore.Text = "";
            單一學生.Enabled = true;
            隨機加入.Enabled = true;
            隨機20.Enabled = true;
            總結.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stg.allch = 0;
            stg.allen =0;
            stg.allmath = 0;
            stg.MaxCn = 0;
            stg.MaxEn = 0;
            stg.MaxMath = 0;
            stg.MinCn = 999;
            stg.MinEn = 999;
            stg.MinMath = 999;
            for(int i = 0; i < im; i++)
            {
                stg.allch += grand[i].CH;
                stg.allen += grand[i].EN;
                stg.allmath += grand[i].Math;
            }
            for (int r = 0; r <im; r++)
            {
                if(grand[r].CH>stg.MaxCn)
                {
                    stg.MaxCn = grand[r].CH;
                }
                if (grand[r].EN > stg.MaxEn)
                {
                    stg.MaxEn = grand[r].EN;
                }
                if (grand[r].Math > stg.MaxMath)
                {
                    stg.MaxMath = grand[r].Math;
                }
                if (grand[r].CH < stg.MinCn)
                {
                    stg.MinCn = grand[r].CH;
                }
                if (grand[r].Math < stg.MinMath)
                {
                    stg.MinMath = grand[r].Math;
                }
                if (grand[r].EN < stg.MinEn)
                {
                    stg.MinEn = grand[r].EN;
                }
            }
            stg.avecn =Math.Round( (stg.allch / im),1);
            stg.aveen = Math.Round((stg.allen) / im, 1);
            stg.avemath = Math.Round((stg.allmath / im), 1);
            allscore.Text=string.Concat(string.Format("總分{0,6} {1,6}{2,6}\n", stg.allmath ,stg.allen ,stg.allch), string.Format("平均{0,8:N1} {1,6:N1}{2,6:N1}\n", stg.avemath , stg.aveen , stg.avecn), string.Format("最高分{0,6}{1,6}{2,6}\n", stg.MaxMath, stg.MaxEn, stg.MaxCn), string.Format("最低分{0,6}{1,6}{2,6}", stg.MinMath,stg.MinEn,stg.MinCn));
            隨機20.Enabled = false;
            總結.Enabled = false;
            單一學生.Enabled = false;
            隨機加入.Enabled = false;
        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void 作業5_Load(object sender, EventArgs e)
        {

        }

        private void 隨機加入_Click(object sender, EventArgs e)
        {
            
            總結.Enabled = true;

              //  im++;
                int rr = R.Next(0, 100), xr = R.Next(0, 100), yr = R.Next(0, 100);
                grand[im].Name = Convert.ToString(im+1);
                grand[im].Math = rr;
                grand[im].EN = xr;
                grand[im].CH = yr;
                grand[im].All = (grand[im].Math + grand[im].EN + grand[im].CH);
                grand[im].Avg = (grand[im].All) / 3;
                int[] x = { grand[im].CH, grand[im].EN, grand[im].Math };
                string[] y = { "國文", "英文", "數學" };
                grand[im].MAx = x[0];
                grand[im].Min = x[0];
                grand[im].Maxscore = y[0];
                grand[im].Minscore = y[0];
                for (int r = 0; r < x.Length; r++)
                {
                    if (grand[im].MAx < x[r])
                    {
                        grand[im].MAx = x[r];
                        grand[im].Maxscore = y[r];
                    }
                    if (grand[im].Min > x[r])
                    {
                        grand[im].Min = x[r];
                        grand[im].Minscore = y[r];
                    }
                }
                scorename.Text = $"{"姓名".PadRight(3)}{"數學".PadRight(3)}{"英文".PadRight(3)}{"國文".PadRight(3)}{"總分".PadRight(3)}{"平均".PadRight(3)}{"最低分".PadRight(3)}{"最高分".PadRight(3)}";
                // score.Text+= string.Format("{0,6}{1,6}{2,6}", grand[im].Name, grand[im].Math, grand[im].EN)+ string.Format("{0,6}{1,6}{2,6:N1}", grand[im].CH, grand[im].All, grand[im].Avg)+string.Format("{0,6}{1,6}", grand[im].Minscore + grand[im].Min, grand[im].Maxscore + grand[im].MAx)+"\n";

                Label Score = score;
                Score.Text = string.Concat(score.Text, string.Format("{0,6}{1,6}{2,6}", (grand[im].Name), grand[im].Math, grand[im].EN), string.Format("{0,6}{1,6}{2,6:N1}", grand[im].CH, grand[im].All, grand[im].Avg), string.Format("{0,6}{1,6}\n", grand[im].Minscore + grand[im].Min, grand[im].Maxscore + grand[im].MAx));
            im++;
            if (im == 50)
            {
                MessageBox.Show("資料過載,請刪除多餘資料", "告知", MessageBoxButtons.OK);
                單一學生.Enabled = false;
                隨機20.Enabled = false;
                隨機加入.Enabled = false;
                
            }
        }

        private void 隨機20_Click(object sender, EventArgs e)
        {
           
            總結.Enabled = true;
         // int rr = R.Next(0, 100), xr = R.Next(0, 100), yr = R.Next(0, 100);
            for (int i=0;i<20 ; i++)
            {
                im ++;
               int rr = R.Next(0, 100), xr = R.Next(0, 100), yr = R.Next(0, 100);
                grand[i].Name = Convert.ToString(im);
                grand[i].Math = rr;
                grand[i].EN = xr;
                grand[i].CH = yr;
                grand[i].All = (grand[i].Math + grand[i].EN + grand[i].CH);
                grand[i].Avg = (grand[i].All) / 3;
                int[] x = { grand[i].CH, grand[i].EN, grand[i].Math };
                string[] y = { "國文", "英文", "數學" };
                grand[i].MAx = x[0];
                grand[i].Min = x[0];
                grand[i].Maxscore = y[0];
                grand[i].Minscore = y[0];
                for (int r = 0; r < x.Length; r++)
                {
                    if (grand[i].MAx < x[r])
                    {
                        grand[i].MAx = x[r];
                        grand[i].Maxscore = y[r];
                    }
                    if (grand[i].Min > x[r])
                    {
                        grand[i].Min = x[r];
                        grand[i].Minscore = y[r];
                    }

                
                }
                if (im >=51)
                {
                    MessageBox.Show("資料過載,請刪除多餘資料", "告知", MessageBoxButtons.OK);
                    單一學生.Enabled = false;
                    隨機20.Enabled = false;
                    隨機加入.Enabled = false;
                    break;
                }
                //  score.Text = $"{"姓名".PadRight(3)}{"數學".PadRight(3)}{"英文".PadRight(3)}{"國文".PadRight(3)}{"總分".PadRight(3)}{"平均".PadRight(3)}{"最低分".PadRight(3)}{"最高分".PadRight(3)}"+"\n";
                scorename.Text = $"{"姓名".PadRight(3)}{"數學".PadRight(3)}{"英文".PadRight(3)}{"國文".PadRight(3)}{"總分".PadRight(3)}{"平均".PadRight(3)}{"最低分".PadRight(3)}{"最高分".PadRight(3)}";

                Label Score = score;
                Score.Text =string.Concat(Score.Text, string.Format("{0,6}{1,6}{2,6}", grand[i].Name,grand[i].Math,grand[i].EN), string.Format("{0,6}{1,6}{2,6:N1}", grand[i].CH,grand[i].All, grand[i].Avg), string.Format("{0,6}{1,6}\n", grand[i].Minscore+grand[i].Min,grand[i].Maxscore+grand[i].MAx));

            }
            Thread.Sleep(20);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
