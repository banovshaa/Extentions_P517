using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_collections.Exceptions
{
     class BookNotFoundException : Exception
    {
        public BookNotFoundException(string msg) :base(msg)
        {
            
        }
    }
}
