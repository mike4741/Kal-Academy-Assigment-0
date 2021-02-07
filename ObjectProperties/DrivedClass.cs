using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProperties
{
    class DrivedClass : BaseClass
    {
        public DrivedClass(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public double  GetCost()
        {
            return Cost * 12;

        }
     }
}
