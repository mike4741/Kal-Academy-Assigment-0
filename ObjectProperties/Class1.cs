using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProperties
{
    //uisng object prpertirties
    class Firute2
    {
        public static string FType = "march";
        private string kind;
        private double cost;

        public string Kind   
            {
              get { return kind; }
              set
                  {
                     if(value== "macintosh")
                       {
                         kind = "Apple";
                       }
                  }

            }
        public double Cost
        {
            get { return cost; }
            set
               {
                 if (cost<0.6)
                     {
                       cost = 0.6;
                     }
                            
               }
        }

        public string GetFiruit()
        {
            return kind;
        }

        public double GetCost()
        {
            return cost * 12;
        }
    }
}
