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
            // int[] test = { -89,1, 25, 3, 4, 5, 6, 700, 8, 9, 10 };
            //var tess = test.Select((NUM, index) => new { Number = NUM, Index = index }).Select(a=>a.Number);
            //int max = 0;
            //foreach (var item in tess)
            //{
            //    Console.WriteLine(item );
            //}
            //for (int i = 0; i < test.Length; i++)
            //{

            //    if (test[i]>max)
            //    {
            //        max = test[i];
            //    }
            //}
            //int result = test.Aggregate((a,b)=>a+b);
            //TSQL2012Entities db = new TSQL2012Entities();
            //List<Employee> emp = db.Employees.ToList();
            //var dd = emp.Select((add,index)=> new { address= add.address,Index = index}).Where(c=>c.Index==1);
            //var jiji = emp.Select(v => new { Address = v.address,Country = v.country});
            //foreach (var item in jiji)
            //{
            //    Console.WriteLine(item.Address + "-3455345" + item.Country);
            //}
            IEnumerable<string> subjects = Class1.GetAllStudets().SelectMany(x => x.Subject);
            
            
            //foreach (var item in subjects)
            //{
            //    Console.WriteLine(item.Name+"-"+item.StSubject);
            //}
            //Console.WriteLine(dd.Select(s=>s.address).FirstOrDefault());
          
            
        }
    }
}



