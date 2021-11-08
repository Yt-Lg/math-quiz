using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Math_Quiz
{
    class Program
    {

        static void Main(string[] args)
        {
            int score = 0;
            var symbol = new List<string> { "+", "-", "*", "/" };

            Console.WriteLine("input name");
            string NameInput = Console.ReadLine();
           
            while (true)
            {
                Console.WriteLine("input difficulty: ( Easy | Medium | Hard )");
                Console.WriteLine("(Note: Any answer that isn't a whole number will be rounded to the nearest whole number)");
                string Difficulty = Console.ReadLine();

                    if (Difficulty.Equals("Easy"))
                    {
                        Random random = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            int num1 = random.Next(1, 5);
                            int num2 = random.Next(1, 5);
                            int symbolselected = random.Next(symbol.Count);
                            string symbolstring = Convert.ToString(symbol[symbolselected]);

                            Console.WriteLine("What is: ");
                            Console.Write(num1);
                            Console.Write(symbol[symbolselected]);
                            Console.Write(num2);
                            Console.WriteLine("");
                            int userinput = Convert.ToInt32(Console.ReadLine());

                            if (symbolstring == "*")
                            {
                                int answer = num1 * num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score +=1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else if (symbolstring == "+")
                            {
                                int answer = num1 + num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else if (symbolstring == "-")
                            {
                                int answer = num1 + num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else if (symbolstring == "/")
                            {
                                int answer = num1 / num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                            }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                        }
                    }

                else if (Difficulty.Equals("Medium"))
                    {

                        Random random = new Random();
                        for (int i = 0; i < 20; i++)
                        { 
                            int num1 = random.Next(1, 10);
                            int num2 = random.Next(1, 10);
                            int symbolselected = random.Next(symbol.Count);
                            string symbolstring = Convert.ToString(symbolselected);

                            Console.WriteLine("What is: ");
                            Console.Write(num1);
                            Console.Write(symbol[symbolselected]);
                            Console.Write(num2);
                            Console.WriteLine("");
                            int userinput = Convert.ToInt32(Console.ReadLine());

                            if (symbolstring == "*")
                            {
                                int answer = num1 * num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                            }

                            else if (symbolstring == "+")
                            {
                                int answer = num1 + num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else if (symbolstring == "-")
                            {
                                int answer = num1 + num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else
                            {
                                int answer = num1 / num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                        }
                    }

                else if (Difficulty.Equals("Hard"))
                    {

                        Random random = new Random();
                        for (int i = 0; i < 30; i++)
                        {
                            int num1 = random.Next(1, 20);
                            int num2 = random.Next(1, 20);
                            int symbolselected = random.Next(symbol.Count);
                            string symbolstring = Convert.ToString(symbolselected);

                            Console.WriteLine("What is: ");
                            Console.Write(num1);
                            Console.Write(symbol[symbolselected]);
                            Console.Write(num2);
                            Console.WriteLine("");
                            int userinput = Convert.ToInt32(Console.ReadLine());

                            if (symbolstring == "*")
                            {
                                int answer = num1 * num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                            }

                            else if (symbolstring == "+")
                            {
                                int answer = num1 + num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else if (symbolstring == "-")
                            {
                                int answer = num1 + num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");
                                }
                            }

                            else
                            {
                                int answer = num1 / num2;
                                if (userinput == answer)
                                {
                                    Console.WriteLine("Correct.");
                                    score += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect");

                                }
                            }

                        }
                    }

                else
                {
                    Console.WriteLine("invalid input");
                }

                Console.WriteLine("Your final score is: ");
                Console.Write(score);

                StreamWriter sw = new StreamWriter("C:\\Leaderboard.txt");
                sw.WriteLine(NameInput + ": " + score);
                sw.Close();

                String line;
                StreamReader sr = new StreamReader("C:\\Leaderboard.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }

        }

    }
}

