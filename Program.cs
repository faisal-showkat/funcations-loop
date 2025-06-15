using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                checkoddeven(); 
                
        }

          
            static void 
            checkoddeven()

            {
                int y = 1;

                do
                {
                    if (y % 2 == 0)
                    {
                        Console.WriteLine(y + " is an even number");
                    }
                    else
                    {
                        Console.WriteLine(y + " is an odd number");
                    }

                    y++;
                } while (y <= 10);
            int fact = 1;
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            int x = 1;
            do
            {
                fact = fact + x;
                x++;
            }
            while (x < a);
            Console.WriteLine(" fact of" + a + "is" + fact);
            int b = 0;
            int c = 1;
            int d;
            Console.WriteLine(b);
            Console.WriteLine(c);
            int e = 0;
            do
            {
                d = b + c;
                Console.WriteLine(d);
                b = c; c = d;
                e++;
            }
            while (e < 20);

        }
    }
    }

    

