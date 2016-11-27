using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Class1
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<string> Subject { get; set; }
        public static List<Class1> GetAllStudets()
        {
            List<Class1> students = new List<Class1>
            {
            new Class1
            {
                id=1,
                Name = "Mickey",
                Subject = new List<string> {"C#","ASP","LINQ"}
            },
            new Class1
            {
                id=2,Name="Tinku", Subject= new List<string> {"DSA","ECE","SSS"}
            },

        };
            return students;
        }

    }
   
}
