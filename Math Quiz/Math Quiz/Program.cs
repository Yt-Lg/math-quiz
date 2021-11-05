using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> symbol = new List<string>() { "+", "-", "*", "/" };

            Console.WriteLine("input name");
            string NameInput = Console.ReadLine();

            Console.WriteLine("input difficulty ( Easy | Medium | Hard )");
            string Difficulty = Console.ReadLine();

            if (Difficulty == "Easy")
            {
                while(true)
                {
                    Random random = new Random();
                    for (int i = 0; i < 10; i++)
                    {
                        int num1 = random.Next(1, 5);
                    }

                   

                }
            }

            else if (Difficulty == "Medium")
            {
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {
                    int num1 = random.Next(1, 5);
                }



            }

            else if (Difficulty == "Hard")
            {
                Random random = new Random();
                for (int i = 0; i < 30; i++)
                {
                    int num1 = random.Next(1, 5);
                }



            }

            else
            {
                Console.WriteLine("invalid input");
            }

        }

    }
}

