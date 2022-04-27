using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Body_Mass_Index_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your mass: ");
            double mass = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please write your hight: ");
            double hight = Convert.ToDouble(Console.ReadLine());

            double Endex = (mass) / (hight * hight);

            if (Endex <= 18)
            {
                Console.WriteLine("According to endex you are 'Weak'.");
                Console.Write("Body Mass Endex: " + Endex);
            }

            else if (Endex > 18 && Endex <= 25)
            {
                Console.WriteLine("According to endex you are 'Normal'.");
                Console.Write("Body Mass Endex: " + Endex);
            }

            else
            {
                Console.WriteLine("According to endex you are 'Obese Individual'. ");
                Console.Write("Body Mass Endex: " + Endex);
            }

            Console.WriteLine("\n");

            for(int i = 1; i<=10; i++)
            {
                for(int j=1; j<=i; j++ )
                {
                    Console.Write(j);
                }

                Console.WriteLine("");

            }

            Console.ReadLine();


        }
    }
}
