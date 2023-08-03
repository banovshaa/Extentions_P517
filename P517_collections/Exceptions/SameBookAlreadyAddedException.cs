using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_collections.Exceptions
{
     class SameBookAlreadyAddedException:Exception
    {
        public SameBookAlreadyAddedException(string msg) :base(msg) 
        {
            
        }
    }
}
