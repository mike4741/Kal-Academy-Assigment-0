using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProperties
{
    class Firute3
    {
        private string kind;
        private double cost;
        public Firute3(string k, double c)
        {
            this.kind = k;
            this.cost = c;
        }
        public string GetKind()
        {
            return this.kind;
        }

        public Double GetCost()
        {
            return this.cost * 12;
        }
            
       
    }
}
