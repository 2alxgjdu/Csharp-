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
    public partial class 作業9 : Form
    {
        public 作業9()
        {
            InitializeComponent();
        }

        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void 作業7_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int d;
            bool x = int.TryParse(樹.Text, out d);
            string y = "*";
            結果1.Text = "";
            if (x)
            {


                for (int i = 0; i <=d; i++)
                {
                    for (int j = 0; j <= d; j++)
                    {
                        if (i > j)
                        {

                            //結果1.Text = 結果1.Text + y;
                            Label label = 結果1;
                            label.Text = label.Text + y;

                        }                
                    }
                    if (i >= 1)
                    {
                        //結果1.Text = 結果1.Text + "\n";
                        Label z = 結果1;
                        z.Text = z.Text + "\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                樹.Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;
            bool x = int.TryParse(猜數字.Text, out i);
            j = i % 2;
            if (x)
            {
                if (j == 0)
                {
                    結果1.Text = "結果:" + i + "是偶數";
                }

                else if (j == 1)
                {
                    結果1.Text = "結果:" + i + "是奇數";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                猜數字.Clear();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 579 };
            int max = arr0711[0];
            int min = arr0711[0];
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (max < arr0711[i])
                {
                    max = arr0711[i];

                }
                if (min > arr0711[i])
                {
                    min = arr0711[i];

                }
            }
            結果1.Text = "結果:" + "int陣列arr0711[1,5,6,8,7,97,57,887,65,578]" + "\n最大值為" + max + "\n最小值為" + min;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] arr0711 = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
                int x = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
 
                if (arr0711[i].Contains('C'))
                {
                    x=x+1;
                }
                else if(arr0711[i].Contains('c'))
                 {
                    x++;
                }
            }
            結果1.Text = "結果:" + "\n陣列arr0711:mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker" + "\n有C及c的名字共有"
    + x + "位";
            // arr0711[0].LastIndexOf('C', 1, 12);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int x = 0, y = 0, z = 0;

            for (int i = 0; i < arr0711.Length; i++)
            {
                z = arr0711[i] % 2;
                if (z == 0)
                {
                    y++;
                }
                else if (z == 1)
                {
                    x++;
                }

            }
            結果1.Text = "結果int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n奇數共:" + x + "\n偶數共" + y;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr0711 = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int[] maxarr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int max = 0, y = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (max < arr0711[i].Length)
                {
                    max = arr0711[i].Length;
                    y = maxarr[i];
                }
            }
            結果1.Text = "結果陣列arr0711_STR[mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]"
            + "\n最長的名字為" + arr0711[y];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            結果1.Text = "";
            int ans;
            int[,] a = new int[10,10];
            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        int y = 1;
                        ans = y;
                        a[i, j] = y;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                    else if (i == 9 || j == 9)
                    {
                        int y = 1;
                        ans = y;
                        a[i, j] = y;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                    else
                    {
                        int z = 0;
                        ans = z;
                        a[i, j] = z;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                }
                Label x = 結果1;
                x.Text = x.Text + "\n";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int x = 100;
            int y;
            string z = "";
            while (x > 0)
            {
                y = x % 2;
                x /= 2;
                z = y.ToString() + z;

            }
            結果1.Text = z;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int[] r = new int[6];
            for (int i = 0; i < 6; i++)
            {
                r[i] = x.Next(1, 49);

                for (int j = 0; j < i; j++)
                {
                    while (r[j] == r[i])
                    {
                        j = 0;
                        r[i] = x.Next(1, 49);
                    }
                }
            }
            結果1.Text = "樂透開獎" + "\n" + r[0] + "  " + r[1] + "  " + r[2] + "  " + r[3] + "  " + r[4] + "  " + r[5];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int x = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                x += arr0711[i];
            }
            結果1.Text = "結果int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n加總為" + x;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 579 };
            int max = arr0711[0];
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (max < arr0711[i])
                {
                    max = arr0711[i];

                }

            }
            結果1.Text = "結果:" + "int陣列arr0711[1,5,6,8,7,97,57,887,65,578]" + "\n最大值為" + max;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 579 };
            int min = arr0711[0];
            for (int i = 0; i < arr0711.Length; i++)
            {

                if (min > arr0711[i])
                {
                    min = arr0711[i];

                }
            }
            結果1.Text = "結果:" + "int陣列arr0711[1,5,6,8,7,97,57,887,65,578]" + "\n最小值為" + min;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            結果1.Text = "結果";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            Swap(ref a, ref b);
            結果1.Text = "換位前a=100,b=200\n" + "換位後a=" + a + "b=" + b;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            結果1.Text = "九九乘法表\n";
            for (int x = 1; x <= 9; x++)
            {


                for (int i = 2; i <= 9; i++)
                {
                    Label label = 結果1;
                    label.Text = label.Text + i + "乘" + x + "=" + x * i+"   ";

                }
                Label labelx= 結果1;
                labelx.Text = labelx.Text + "\n"; 
             }

             
        }

        private void button9_Click(object sender, EventArgs e)
        {
            結果1.Text = "";
            int ans;
            int[,] a = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            int ass = 0;
                            ans = ass;
                            a[i, j] = ass;
                            Label label = 結果1;
                            label.Text = label.Text + a[i, j];
                        }
                        else
                        {
                            int bss = 1;
                            ans = bss;
                            a[i, j] = bss;
                            Label label = 結果1;
                            label.Text = label.Text + a[i, j];
                        }
                    }
                    else if (j % 2 != 0)
                    {
                        int css = 1;
                        ans = css;
                        a[i, j] = css;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                    else
                    {
                        int last = 0;
                        ans = last;
                        a[i, j] = last;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }

                }
                Label x = 結果1;
                x.Text = x.Text + "\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            結果1.Text = "";
            int ans;
            int[,] a = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        int y = 0;
                        ans = y;
                        a[i, j] = y;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                    else if (i == 9 || j == 9)
                    {
                        int y = 0;
                        ans = y;
                        a[i, j] = y;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                    else
                    {
                        int z = 1;
                        ans = z;
                        a[i, j] = z;
                        Label label = 結果1;
                        label.Text = label.Text + a[i, j];
                    }
                }
                Label x = 結果1;
                x.Text = x.Text + "\n";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int d,o,f,g,ans=0;
            bool c= int.TryParse(距1.Text, out d);
            bool s = int.TryParse(距1.Text, out g);
            bool b = int.TryParse(距2.Text, out o);
            bool a = int.TryParse(距3.Text, out f);

            if (c&&b&&a&&s)
            {
                for (int i = d; i <= o; i++)
                {

                    if (d <= o)
                    {
                        ans += d;
                        d += f;
                    }


                    結果1.Text = g + "到" + o + "相隔" + (f - 1) + "\n加總為" + ans;
                }
            }
            else if (o == 0)
            {
                MessageBox.Show("請輸入0以外的數字");
                距3.Clear();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                距1.Clear();
                距2.Clear();
                距3.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int d, o, f, g ,ans = 0;
            bool c = int.TryParse(距1.Text, out d);
            bool s = int.TryParse(距1.Text, out g);
            bool b = int.TryParse(距2.Text, out o);
            bool a = int.TryParse(距3.Text, out f);

            if (c && b && a&&s)
            {
                
                while (d <= o)
                {
                    ans += d;
                    d += f;
                }

                結果1.Text = g + "到" + o + "相隔" + (f - 1) + "\n加總為" + ans;
                
            }
            else if (o == 0)
            {
                MessageBox.Show("請輸入0以外的數字");
                距3.Clear();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                距1.Clear();
                距2.Clear();
                距3.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int d, o, f, g, ans = 0;
            bool c = int.TryParse(距1.Text, out d);
            bool s = int.TryParse(距1.Text, out g);
            bool b = int.TryParse(距2.Text, out o);
            bool a = int.TryParse(距3.Text, out f);

            if (c && b && a)
            {
                do
                {
                    ans += d;
                    d += f;
                }
                while (d <= o);


                結果1.Text = g + "到" + o + "相隔" + (f - 1) + "\n加總為" + ans;

            }
            else if (o == 0)
            {
                MessageBox.Show("請輸入0以外的數字");
                距3.Clear();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                距1.Clear();
                距2.Clear();
                距3.Clear();
            }
        }
    }
    
}
