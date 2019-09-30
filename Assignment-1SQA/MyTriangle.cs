using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1SQA
{
    class MyTriangle
    {
        string choiceString,Message;
        int choice, triangleSideA, triangleSideB, triangleSideC;

        public void getTriangleSides()
        {
            do
            {
                Console.WriteLine("1 for Enter Trianle 2 for Exit ");
                choiceString = Console.ReadLine();


            } while (!int.TryParse(choiceString, out choice));


                switch (choice) {


                case 1:
                    string sideA, sideB, sideC;
                    
                    Console.WriteLine("Enter Triangle side one:");
                    sideA = Console.ReadLine();
                    Int32.TryParse(sideA, out triangleSideA);

                    Console.WriteLine("Enter Triagnle side Two:");
                    sideB = Console.ReadLine();
                    Int32.TryParse(sideB, out triangleSideB);

                    Console.WriteLine("Enter Triangle side three:");
                    sideC = Console.ReadLine();
                    Int32.TryParse(sideC, out triangleSideC);

                     Message = triangleChecker();
                    Console.WriteLine(Message);



                    break;

                case 2:

                    break;



            }

         }

        public string triangleChecker()
        {

            if ((triangleSideA + triangleSideB >= triangleSideC) && (triangleSideA + triangleSideC >= triangleSideB)

                && (triangleSideB + triangleSideC >= triangleSideA))
            {

                return "These Sides can form triangle ";

            }

            else
            {
               return  "These Side can not from triangle ";
            }
            
           // return " ";

        }

    }
}
