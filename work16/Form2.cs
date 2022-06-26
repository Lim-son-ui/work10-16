using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Random rd = new Random();
            //int rd_num = rd.Next(0, 100);
            //MessageBox.Show(rd_num.ToString());
        }

        Param para = new Param();
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            MessageBox.Show("Form1數字" + para.rd_num);
            //MessageBox.Show(para.Param())
            MessageBox.Show("Form2數字" + para.rd_num);
            
        }
    }
}
