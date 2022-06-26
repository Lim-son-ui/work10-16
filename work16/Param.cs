using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work16
{
    public class Param
    {
        public int min = 0, max = 100;
        public int rd_num { get; }

        public Param(){
            Random rd = new Random();
            rd_num = rd.Next(0, 100);
            //MessageBox.Show(rd_num.ToString());
        }

    }
    
}
