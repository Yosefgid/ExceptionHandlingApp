using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    public class NegativeIntegerInputException : Exception
    {
        public NegativeIntegerInputException(int[] values)
            : base($"The following negative integers(s) are not allowed in this operation: [{string.Join(", ", values)}]")
        {

        }
    }
}
