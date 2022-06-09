using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            try
            {
                Console.Write("Podaj wartość parametru a: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception("a nie może się równać 0");

                }

           

                Console.Write("Podaj wartość parametru b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wartość parametru c: ");
                c = Convert.ToDouble(Console.ReadLine());

                delta = b * b - 4 * a * c;

                x1 = (-b-Math.Sqrt(delta))/2*a;
                x2 = (-b + Math.Sqrt(delta)) / 2*a;

                if (delta > 0)
                {
                    
                    Console.WriteLine("Równanie ma dwa pierwiastki x1 = "  + x1 +"   i x2 = " + x2);
                }else if(delta == 0)
                {
                    Console.WriteLine("Równanie ma jeden pierwiastek " + x1);
                }
                else
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("Program został przerwany " + ex.Message);

                
            }
            Console.ReadKey();
        }
    }
}
