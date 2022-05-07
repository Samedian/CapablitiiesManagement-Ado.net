using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class StringContainDigitException : Exception
    {
        public StringContainDigitException(string msg) : base(msg)
        {

        }
    }
}
