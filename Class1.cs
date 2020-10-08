using System;
using System.Collections.Generic;
using System.Text;

namespace assign_2
{
    public static class TriangleSolver
    {
        public static string Analyze(int sidea, int sideb, int sidec)
        {
            string result;
            //logic for checking the triangle is euilateral,isosceles or scalene triangle.
                if (sidea == sideb && sideb == sidec)
                {
                    result = "This is an equilateral triangle.";
                   
                }
                else if (sidea == sideb || sidea == sidec || sideb == sidec)
                {
                    result = "This is an isosceles triangle.";
                    
                }
                else
                {
                    result = "This is a scalene triangle.";
                    
                }
            return result;
        }
    }
}
