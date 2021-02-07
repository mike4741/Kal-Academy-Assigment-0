using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProperties
{

 
    class Events
    {
        public event EventHandler NewEvent;
        private string kind;
        public string Kind
        {
            get { return kind; }
            set { kind = value;
                  NewEvent(this, EventArgs.Empty);
            }
              
        }    
       
    }
}
