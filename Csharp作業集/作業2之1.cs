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
    public partial class 貸款計算 : Form
    {
        public 貸款計算()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string money = moneytx.Text;
            string year = yeartx.Text;
            string percent = percenttx.Text;
            string fmoney = fmoneytx.Text;
            double m1 = double.Parse(money); //貸款金額
            double m2 = double.Parse(year)*12;  //期限 年
            double m3 = double.Parse(percent)/100;// 利率 
            double m4 = double.Parse(fmoney);//頭期款
            double m5 = m3 / 12; //年利率轉成月利率
            double m6 = (Math.Pow((1 + m5),m2)*m5)/(Math.Pow((1+m5),m2)-1); //每月應還本息金額之平均攤還率
            double m7 = m1 - m4;//貸款扣掉頭期款
            double m8 = Math.Floor(m7 * m6);//平均每月該還本息金額+四捨五入
            MessageBox.Show("月付" + m8+"元");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            double m1 = double.Parse(moneytx.Text); //貸款金額
            double m2 = double.Parse(yeartx.Text) * 12;  //期限 年
            double m3 = double.Parse(percenttx.Text) / 100;// 利率 
            double m4 = double.Parse(fmoneytx.Text);//頭期款
            double m5 = m3 / 12; //年利率轉成月利率
            double m6 = (Math.Pow((1 + m5), m2) * m5) / (Math.Pow((1 + m5), m2) - 1); //每月應還本息金額之平均攤還率
            double m7 = m1 - m4;//貸款扣掉頭期款
            double m8 = Math.Floor(m7 * m6);//平均每月該還本息金額+四捨五入
            MessageBox.Show("總金額"+m8*m2+"元");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
          總結 all  =new 總結();
            all.lb1.Text = moneytx.Text; //貸款金額
            all.lb2.Text = yeartx.Text;//期限
            all.lb3.Text = percenttx.Text;//利率
            double m1 = double.Parse(moneytx.Text); //貸款金額
            double m2 = double.Parse(yeartx.Text) * 12;  //期限 年
            double m3 = double.Parse(percenttx.Text) / 100;// 利率 
            double m4 = double.Parse(fmoneytx.Text);//頭期款
            double m5 = m3 / 12; //年利率轉成月利率
            double m6 = (Math.Pow((1 + m5), m2) * m5) / (Math.Pow((1 + m5), m2) - 1); //每月應還本息金額之平均攤還率
            double m7 = m1 - m4;//貸款扣掉頭期款
            double m8 = Math.Floor(m7 * m6);//平均每月該還本息金額+四捨五入
            all.lb4.Text =Convert.ToString(m8);//月付額
            all.lb5.Text =Convert.ToString(m8*12);//總付額
            all.Show();
        }
    }
}
