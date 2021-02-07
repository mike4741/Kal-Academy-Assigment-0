using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ObjectProperties
{
    class switchTest
    {
        string wt = "hello word";
        //File.writeText ("file.txt", wt);
            

        enum Level
        {
            low,
            medium,
            high
        }

        public void sw()
        {
            Level val = Level.low;
            switch(val)
            {
                case Level.high:
                    Console.WriteLine("high level");
                    break;
                case Level.medium:
                    Console.WriteLine("Medium");
                    break;
                case Level.low:
                    Console.WriteLine("Low");
                    break;
                    
            }
               
                    
        }

    }
}
