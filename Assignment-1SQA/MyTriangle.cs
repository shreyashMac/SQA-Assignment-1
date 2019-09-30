using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_1SQA
{
     public class MyTriangle
    {
        string choiceString,Message;
        int choice, triangleSideA, triangleSideB, triangleSideC;

        public void getTriangleSides()
        {
            do
            {
                Console.WriteLine(" **** Enter 1 for Triangle**** \n 2 for Exit ");
                choiceString = Console.ReadLine();


            } while (!int.TryParse(choiceString, out choice));


                switch (choice) {


                case 1:
                    string sideA, sideB, sideC;

                    do
                    {
                        Console.WriteLine("Enter Triangle side one:\n");
                        sideA = Console.ReadLine();
                    } while (!Int32.TryParse(sideA, out triangleSideA));

                    do
                    {
                        Console.WriteLine("Enter Triagnle side Two:");
                        sideB = Console.ReadLine();
                    }while(!Int32.TryParse(sideB, out triangleSideB));

                    do {
                        Console.WriteLine("Enter Triangle side three:");
                        sideC = Console.ReadLine();
                    }while(!Int32.TryParse(sideC, out triangleSideC));



                   Message = TriangleSolver.analyze(triangleSideA, triangleSideB, triangleSideC);
                    Console.WriteLine(Message);



                    break;

                case 2:

                    break;



            }

         }

      

    }
}
