using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3_triangle
{
    public class Triangle
    {
        public Triangle()
        {

        }
        public double getHypotenuse(double sideA, double sideB)
        {
            double answer = 0;
    
            answer = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return answer;
        }

    }
}
