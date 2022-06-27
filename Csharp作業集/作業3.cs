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
    public partial class 菜單 : Form
    {
        public 菜單()
            {
                InitializeComponent();
            }
        public const int ju01 = 30, ju02 = 35, all = 250, choco = 220 ; //菜單價格
        public  int Ju01 = 0, Ju02 = 0, Al = 0, Ch = 0, pricemoney = 0;//按鈕點擊用

        private void 菜單_Load(object sender, EventArgs e)
        {

        }

        private void chocoLB_Click(object sender, EventArgs e)
        {
            Ch++;
            pricemoney += choco;
            pc.Text = "NT$" + pricemoney + "元";
            if (Ch >= 0)
            {

                Chl = "巧克力百匯" + Convert.ToString(Ch) + "份" + ",共NT$" + Convert.ToString(choco * Ch) + "元\n";

            }

            money.Text = Convert.ToString(Ju01l) + Convert.ToString(Ju02l) + Convert.ToString(All) + Convert.ToString(Chl);
        }  

        private void cash_Click(object sender, EventArgs e)
        {
            if(pricemoney>=1)
            {
                MessageBox.Show("總金額"+Convert.ToString(pricemoney)+"NT$", "確認付款");
            }
            else
            {
                MessageBox.Show("請點餐!!", "並未點餐");
            }
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (pricemoney >= 1)
            {
                MessageBox.Show("總金額" + Convert.ToString(pricemoney)+"NT$\n"+"信用卡打折後"+ Convert.ToString(Math.Floor(pricemoney*0.9))+"NT$", "確認付款");
            }//Math.Floor四捨五入取整數
            else
            {
                MessageBox.Show("請點餐!!", "並未點餐");
            }
        }

        public void clear_Click(object sender, EventArgs e)
        {

            Ju01 = 0;
            Ju02 = 0; Al = 0; Ch = 0 ;
            pricemoney =0;  //清除菜單用  
                money.Text = "尚未點餐";
            Ju01l = "";
            Ju02l = "";
            All = "";
            Chl = "";
            pc.Text ="NT$"+ pricemoney+"元";


        }

        private void money_Click(object sender, EventArgs e)
        {

        }

        private void allLB_Click(object sender, EventArgs e)
        {

            Al++;
            pricemoney +=all;
            pc.Text = "NT$" +pricemoney+  "元";
            if (Al >= 0)
            {

                All = "綜合百匯" + Convert.ToString(Al) + "份" + ",共NT$" + Convert.ToString(Al*all) + "元\n";

            }
            money.Text = Convert.ToString(Ju01l) + Convert.ToString(Ju02l) + Convert.ToString(All) + Convert.ToString(Chl);
        }

        private void julice02LB_Click(object sender, EventArgs e)
        {
            Ju02++;
            pricemoney += ju02;
            pc.Text = "NT$" + pricemoney + "元";
            if (Ju02 >= 0)
            {

                Ju02l = "檸檬汁" + Convert.ToString(Ju02) + "份" + ",共NT$" + Convert.ToString(Ju02*ju02) + "元\n";
            }

            money.Text = Convert.ToString(Ju01l) + Convert.ToString(Ju02l) + Convert.ToString(All) + Convert.ToString(Chl);
        }

        public string Ju01l, Ju02l, All, Chl;


        private void 尚未點餐_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void julice1LB_Click(object sender, EventArgs e)
            {
            Ju01++;
            pricemoney +=ju01;
            pc.Text = "NT$" + pricemoney + "元";
            if (Ju01 >= 0)
            {

                Ju01l = "柳橙汁" + Convert.ToString(Ju01) + "份" + ",共NT$" + Convert.ToString(ju01 * Ju01) + "元\n";
            }
            money.Text = Convert.ToString(Ju01l) + Convert.ToString(Ju02l) + Convert.ToString(All) + Convert.ToString(Chl);
        }
        
    }
}
