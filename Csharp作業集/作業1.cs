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
    public partial class 介紹 : Form
    {
        public 介紹()
        {
            InitializeComponent();
        }

        private void cn_Click(object sender, EventArgs e)
        {
            string name = nametx.Text;
            string enname = ennametx.Text;
            string blood = bloodtx.Text;
            string mg = mgtx.Text;
            MessageBox.Show("你好啊"+name+",\n Hi"+enname+", \n 原來你血型是"+blood+mg+"啊"+", \n 請多指教");
        }

        private void en_Click(object sender, EventArgs e)
        {
            string name = nametx.Text;
            string enname = ennametx.Text;
            string blood = bloodtx.Text;
            string mg = mgtx.Text;
            MessageBox.Show("你好啊" + name + ",\n Hi" + enname + ", \n 原來你血型是" + blood + mg + "啊" + ", \n 請多指教");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
