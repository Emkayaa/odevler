using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {



    
        static void Main(string[] args)
        {
            sekil ucgen = new sekil();
            Console.Write("Üçgenin yüksekliğini girin: ");
            
            int y = Convert.ToInt16(Console.ReadLine());

            Console.Write("karakter gir");
            char z = Convert.ToChar(Console.ReadLine());
            ucgen.ucgen(y);
            
            ucgen.ucgen(y,z);


            Console.ReadKey();
        }

        class sekil
        {
            public void ucgen(int y)
            {
                for (int i = 0; i < y; i++)
                {
                    for (int d = 0; d <= i; d++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            public void ucgen(int y, char z)
            {
                
                for (int i = 0; i < y; i++)
                {
                    for (int d = 0; d <= i; d++)
                    {
                        Console.Write(z);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            } 
            
        }
    }

}

