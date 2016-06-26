using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool isRepeat = true;
            int a=0;
            int b=0;
            while(isRepeat)
            {
                Console.WriteLine("Введите длину стороны A");
                while (!int.TryParse(Console.ReadLine(), out a)) 
                {
                    Console.WriteLine("Введите длину стороны A");
                }

                Console.WriteLine("Введите длину стороны B");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введите длину стороны B");
                }

                if (a > 0 && b > 0)
                    Console.WriteLine("Площадь прямоугольника со сторонами A={0} и B={1} равна {2} ", a, b, a * b);
                else
                    Console.WriteLine("Стороны <=0");

                Console.WriteLine("Повторить? Для повтора введите Y , для выхода введите любую клавишу");
                var str = Console.ReadLine();
                if (!str.ToUpper().Equals("Y"))
                    isRepeat = false;
                Console.WriteLine();
            }            

        }
    }
}
