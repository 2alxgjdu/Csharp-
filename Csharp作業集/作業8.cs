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
    public partial class 作業8 : Form
    {
        public 作業8()
        {
            InitializeComponent();
        }

        private void 作業8_Load(object sender, EventArgs e)
        {

        }
        double i = 0, j = 0,ans=0;

        private void button3_Click(object sender, EventArgs e)
        {
            i = double.Parse(t1.Text);
            j = double.Parse(t2.Text);
            ans = i * j;
            answer.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = double.Parse(t1.Text);
            j = double.Parse(t2.Text);
            ans = i /j;
            answer.Text = $"{Math.Round(ans,4)}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = double.Parse(t1.Text);
            j = double.Parse(t2.Text);
            ans = i - j;
            answer.Text = ans.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = double.Parse(t1.Text);
            j = double.Parse(t2.Text);
            ans = i + j;
            answer.Text= ans.ToString();
        }
    }
}
