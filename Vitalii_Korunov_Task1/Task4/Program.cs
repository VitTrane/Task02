using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        private const int DEFAULT_COUNTS_LINES_IN_TRIANGLE=3;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            int trianglesCount = 0;
            int startPositionChar = 0;
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.WriteLine("Введите кол-во треугольников");
                while (!int.TryParse(Console.ReadLine(), out trianglesCount))
                {
                    Console.WriteLine("Введите кол-во треугольников ");
                }

                //Вывод 1-го треугольника
                startPositionChar = trianglesCount;
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < startPositionChar; k++)
                    {
                        Console.Write(" ");                            
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                for (int k = 0; k < startPositionChar-1; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("***");
                Console.WriteLine();
                
                //Вывод остальных треугольников
                int linesCountInTriangle = DEFAULT_COUNTS_LINES_IN_TRIANGLE;
                startPositionChar = trianglesCount;
                for (int i = 0; i < trianglesCount-1; i++)
                {                    
                    OutputTriangle(linesCountInTriangle,startPositionChar);
                    linesCountInTriangle++;
                }
                
                Console.WriteLine("Повторить? Для повтора введите Y , для выхода введите любую клавишу");
                var str = Console.ReadLine();
                if (!str.ToUpper().Equals("Y"))
                    isRepeat = false;

                Console.Clear();
            }
        }

        private static void OutputTriangle(int linesCountInTriangle,int startPositionChar) 
        {
            string newString = "*";
            for (int j = 0; j < linesCountInTriangle; j++)
            {
                for (int k = 0; k < startPositionChar; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(newString);
                newString += "**";
                startPositionChar--;
                Console.WriteLine();
            }
        }
    }
}
