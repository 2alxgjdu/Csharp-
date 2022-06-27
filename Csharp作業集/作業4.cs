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
    public partial class 成績統計01 : Form
    {
        public testgrand grand = new testgrand(); //可在整個類別使用testgrand的資料
        public 成績統計01()
        {
            InitializeComponent();
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            grand.Name = nametx.Text;
            grand.CH =int.Parse( chinesetx.Text);
            grand.EN =int.Parse( englishtx.Text);
            grand.Math =int.Parse( mathtx.Text);
            //將姓名分數傳遞至testgrand做儲存
        }

        private void appearbt_Click(object sender, EventArgs e)
        {

            //從testgrand取回資料
            allscore.Text = string.Format("姓名：{0}\n國文：{1}分\n英文：{2}分\n數學：{3}分", new object[] { grand.Name, grand.CH, grand.EN, grand.Math });
                                //陣列使用對應字串與整數                                          
                                //因字串整數都有使用所以使用object[]
        }

        private void maxminbt_Click(object sender, EventArgs e) //排列最高最低分
        {
            if (grand.CH > grand.Math)
            {
                if (grand.CH <= grand.EN)
                {
                    // grand.Maxscore = string.Concat("英文", Convert.ToString(grand.EN));
                    grand.Maxscore = "英文:" + Convert.ToString(grand.EN);
                }
                else
                {
                    //grand.Maxscore = string.Concat("國文", Convert.ToString(grand.CH));
                    grand.Maxscore = "國文:" + Convert.ToString(grand.CH);
                }
            }
            else if (grand.Math > grand.EN)
            {
                if (grand.Math <= grand.CH)
                {
                    // grand.Maxscore = string.Concat("國文", Convert.ToString(grand.CH));
                    grand.Maxscore = "國文:" + Convert.ToString(grand.CH);
                }
                else
                {
                    // grand.Maxscore = string.Concat("數學", Convert.ToString(grand.Math));
                    grand.Maxscore = "數學:" + Convert.ToString(grand.Math);
                }
            }
            else if (grand.EN > grand.CH)
            {
                if (grand.EN <= grand.Math)
                {
                    // grand.Maxscore = string.Concat("數學", Convert.ToString(grand.Math));
                    grand.Maxscore = "數學:" + Convert.ToString(grand.Math);
                }
                else
                {
                    //grand.Maxscore = string.Concat("英文", Convert.ToString(grand.EN));
                    grand.Maxscore = "英文:" + Convert.ToString(grand.EN);

                }
            }
            if (grand.CH < grand.Math)
            {
                if (grand.CH >= grand.EN)
                {
                    //grand.Minscore = string.Concat("英文", Convert.ToString(grand.EN));
                    grand.Minscore = "英文:" + Convert.ToString(grand.EN);

                }
                else
                {
                    grand.Minscore = "國文:" + Convert.ToString(grand.CH);
                    //grand.Minscore = string.Concat("國文", Convert.ToString(grand.CH));
                }
            }
            else if (grand.Math < grand.EN)
            {
                if (grand.Math >= grand.CH)
                {
                    // grand.Minscore = string.Concat("國文", Convert.ToString(grand.CH));
                    grand.Minscore = "國文:" + Convert.ToString(grand.CH);
                }
                else
                {
                    //grand.Minscore = string.Concat("數學", Convert.ToString(grand.Math));
                    grand.Minscore = "數學:" + Convert.ToString(grand.Math);
                }
            }
            else if (grand.EN < grand.CH)
            {
                if (grand.EN >= grand.Math)
                {
                    //grand.Minscore = string.Concat("數學", Convert.ToString(grand.Math));
                    grand.Minscore = "數學:" + Convert.ToString(grand.Math);
                }
                else
                {
                    //grand.Minscore = string.Concat("英文", Convert.ToString(grand.EN));
                    grand.Minscore = "英文:" + Convert.ToString(grand.EN);

                }
            }
            //  sizescorelb.Text = string.Concat(new string[] { "成績最高的為:", grand.Maxscore, "分\n成績最差的為:", grand.Minscore, "分 " });
            sizescorelb.Text = "成績最高的為:" + Convert.ToString(grand.Maxscore) + "分\n成績最差的為:" + Convert.ToString(grand.Minscore) + "分";
        
        
         }

        private void 作業4_Load(object sender, EventArgs e)
        {

        }
    }
}
