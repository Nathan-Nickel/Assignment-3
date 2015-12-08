using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    public class InvalidSideException : Exception
    {
        public InvalidSideException()
        {

        }
        public InvalidSideException(string message) : base(message)
        {
        
        }
    }
}
