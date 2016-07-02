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
            bool isRepeat = true;
            int length=0;
            int width=0;
            while(isRepeat)
            {
                Console.WriteLine("Введите длину стороны A");
                while (!int.TryParse(Console.ReadLine(), out length)) 
                {
                    Console.WriteLine("Введите длину стороны A");
                }

                Console.WriteLine("Введите длину стороны B");
                while (!int.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Введите длину стороны B");
                }

                if (length > 0 && width > 0)
                    Console.WriteLine("Площадь прямоугольника со сторонами A={0} и B={1} равна {2} ", length, width, length * width);
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
