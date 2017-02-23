using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideHeight;
            int levels;
            double amouofStone;
            string getInput;
            int totalCube=0;
            while (true)
            {
                Console.WriteLine("How many levels");
                getInput = Console.ReadLine();
             if(!int.TryParse(getInput, out levels) || (0 > levels)) 
                {
                    if (getInput == "q")
                    {
                        Console.WriteLine("Program stopped!");
                        break;
                    } 
                    Console.WriteLine("Incorrect input!");
                    continue;
                }

                Console.WriteLine("Whats side height");
                getInput = Console.ReadLine();
               if(!int.TryParse(getInput, out sideHeight)||(0>sideHeight))
                {
                    if (getInput == "q")
                    {
                        Console.WriteLine("Program stopped!");
                        break;
                    }
                    Console.WriteLine("Incorrect input!");
                    continue;
                }

                Console.WriteLine("How mach stone do you have");
                getInput = Console.ReadLine();
               if(!double.TryParse(getInput, out amouofStone)||(0>amouofStone))
                {
                    if (getInput == "q")
                    {
                        Console.WriteLine("Program stopped!");
                        break;
                    }
                    Console.WriteLine("Incorrect input!");
                    continue;
                }
                

                for (int i = 1; i <= levels; i++)
                {
                    int cube = i * i;
                    totalCube = cube + totalCube;


                }
                sideHeight = sideHeight * sideHeight * sideHeight;
                totalCube = totalCube * sideHeight;
                double totalC;
                Convert.ToDouble(totalC = totalCube);

                if (amouofStone >= totalCube)
                {
                    totalC = amouofStone - totalC;
                    Console.WriteLine("Stone: was " + amouofStone + ",used " + totalCube + ", remeinder " + totalC);
                    break;
                }
                else
                {
                    totalC = totalC - amouofStone;
                    Console.WriteLine("Stone: was " + amouofStone + ",used " + totalCube + ",need " + totalC);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
