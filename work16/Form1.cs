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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Random rd = new Random();
            //int rd_num = rd.Next(0, 100);
            //MessageBox.Show(rd_num.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Param para = new Param();
        Random rd = new Random();
        public int a = 0;
        public int rd_num = 0;

        //int rd_num = rd.Next(0, 100);
       // Random rd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Form1數字"+para.rd_num);
            //if ( this.a==0 )
            //{
            //    rd_num = rd.Next(0, 100);
            //}
            //this.a++;
            //MessageBox.Show("Form1數字"+rd_num);
            Form2 f2 = new Form2();
            f2.Show();

            int guess = 0;
            
            

           // if (guess > Param.rd_num)
            //{
            //    //range between  min~guess;
            //    para.max = guess;
            //    //para.min = 不變
            //}

           // else if(guess < Param.rd_num)
            //{
            //    //range  between  guess~max;
            //    para.min = guess;
            //    //para.max = 不變
            //}

            //else
            //{
                //恭喜猜對
            //}


        }
    }
}
