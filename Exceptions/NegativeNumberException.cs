using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string msg) : base(msg)
        {

        }

        public NegativeNumberException(string msg ,Exception innerException) : base(msg,innerException)
        {
                
        }
    }
}
