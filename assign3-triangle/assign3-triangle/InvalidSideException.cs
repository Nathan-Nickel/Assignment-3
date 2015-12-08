using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3_triangle
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
