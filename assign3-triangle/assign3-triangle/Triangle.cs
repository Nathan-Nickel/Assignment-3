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
            if (sideA < 0 && sideB < 0)
            {
                throw new InvalidSideException("both inputs were less than 0: " + sideA + ", " + sideB);
            }
            else
            {
                if (sideA >= 0)
                {
                    if (sideB >= 0)
                    {
                        answer = Math.Sqrt((sideA * sideA) + (sideB * sideB));
                    }
                    else
                    {
                        throw new InvalidSideException("second input was less than 0: " + sideB);
                    }
                }
                else
                {
                    throw new InvalidSideException("first input was less than 0: " + sideA);
                }
            }
            

            return answer;
        }

        public double getArea(double sideA, double sideB)
        {
            double answer = 0;

            if (sideA < 0 && sideB < 0)
            {
                throw new InvalidSideException("both inputs were less than 0: " + sideA + ", " + sideB);
            }
            if (sideA >= 0)
            {
                if (sideB >= 0)
                {
                    answer = (sideA * sideB) * .5;
                }
                else
                {
                    throw new InvalidSideException("second input was less than 0: " + sideB);
                }
            }
            else
            {
                throw new InvalidSideException("first input was less than 0: " + sideA);
            }

            return answer;
        }


    }
}
