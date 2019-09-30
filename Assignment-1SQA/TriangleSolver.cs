using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1SQA
{
   public  static class TriangleSolver
    {
        public static string  analyze(int triangleSideA, int triangleSideB, int triangleSideC)
        {

            if ((triangleSideA + triangleSideB >= triangleSideC) && (triangleSideA + triangleSideC >= triangleSideB)

                && (triangleSideB + triangleSideC >= triangleSideA))
            {

                //return "These Sides can form triangle";
                if ((triangleSideA == triangleSideB) && (triangleSideB == triangleSideC)
                         && (triangleSideA == triangleSideC))
                {

                    return "Triangle Formed and Triangle is Equlateral";

                }

                else if ((triangleSideA == triangleSideB) || (triangleSideB == triangleSideC)
                        || (triangleSideA == triangleSideC))
                {
                    return "Triangle Formed and Triangle is Isosceles";
                }

                else
                {

                    return "Triangle Formed and Triangle is Scalene";


                }


            }

            else
            {
                return "Triangle Doesn't form";

            }

            // return " ";

        }

    }

}
