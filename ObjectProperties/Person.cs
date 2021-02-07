using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProperties
{
    class Person
    {
        private string name;
        private int age;

        public string Name{
            get { return name; }
            set { name = value; }
               }
        public int Age
        {
            get; set;
        }

            
    }
}
