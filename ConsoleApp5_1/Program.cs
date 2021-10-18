using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] n = new int[7];
            Console.Write("Введите первое число: ");
            n[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            n[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            n[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            n[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пятое число: ");
            n[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шестое число: ");
            n[5] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите седьмое число: ");
            n[6] = Convert.ToInt32(Console.ReadLine());
            
            {
                foreach (int item in n)
                {
                    Console.WriteLine("Среднеарифмитическое: {0}", (n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6]) / 7);
                    Console.ReadKey();
                }         
                {

                }
            }

        }
    }
}
