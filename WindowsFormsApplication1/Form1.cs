using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             int[] test = { -89,1, 25, 3, 4, 5, 6, 700, 8, 9, 10 };
             
            int max = 0;
            for (int i = 0; i < test.Length; i++)
            {
                
                if (test[i]>max)
                {
                    max = test[i];
                }
            }
            int result = test.Aggregate((a,b)=>a+b);

        }
    }
}



