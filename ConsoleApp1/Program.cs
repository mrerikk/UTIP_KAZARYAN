using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Line to count words");

            Console.WriteLine (CountWords(Console.ReadLine()));

            Console.ReadKey();

        }

        public static int CountWords(string input)
                {
                    var found = false;
                    var count = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != ' ')
                        {
                            if (found == false)
                            {
                                count++;
                            }
                            found = true;
                        }
                        else
                        {
                            found = false;
                        }
                    }


                    return count;
                }
        
    }
}
