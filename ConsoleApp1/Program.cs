using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATION OF THREE SIDES.
            int sideA, sideB, sideC;
            string strsideA, strsideB, strsideC;
            string value = string.Empty;
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        Console.WriteLine("Please Enter the Sides of the Triangle");
                        ///INPUTTING THE VALUES OF THREE SIDES
                        bool isNum;
                        do
                        {
                            Console.WriteLine("Enter Value For First Side");
                            strsideA = Console.ReadLine();
                            isNum = int.TryParse(strsideA, out sideA);
                        } while (!(isNum));
                        do
                        {
                            Console.WriteLine("Enter Value For the Second Side");
                            strsideB = Console.ReadLine();
                            isNum = int.TryParse(strsideB, out sideB);
                        } while (!(isNum));
                        do
                        {
                            Console.WriteLine("Enter Value For the Third Side");
                            strsideC = Console.ReadLine();
                            isNum = int.TryParse(strsideC, out sideC);
                        } while (!(isNum));
                        if ((sideA <= 0) && (sideB <= 0) && (sideC <= 0) && (float.IsNaN(sideA) && (float.IsNaN(sideB) && (float.IsNaN(sideC)))))
                        {
                            Console.WriteLine("It Doesnot Form Triangle");
                            Console.WriteLine("Please Enter Valid Number");
                        }
                        else
                        {
                            Console.WriteLine("It Forms Triangle");
                            Console.WriteLine($" Result  : {Trianglesolver.Analyze(int.Parse(strsideA), int.Parse(strsideB), int.Parse(strsideC))}");
                        }
                        break;
                    case "2":
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Please Enter Valid Number");
                        break;
                }
            }
        }
    }
}

        
    

