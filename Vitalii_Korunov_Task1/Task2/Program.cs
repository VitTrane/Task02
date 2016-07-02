using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int linesCount = 0;
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.WriteLine("Введите кол-во строк");
                while (!int.TryParse(Console.ReadLine(), out linesCount))
                {
                    Console.WriteLine("Введите кол-во строк");
                }

                for (int i = 0; i < linesCount; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Повторить? Для повтора введите Y , для выхода введите любую клавишу");
                var str = Console.ReadLine();
                if (!str.ToUpper().Equals("Y"))
                    isRepeat = false;

                Console.Clear();
            }            
        }
    }
}
