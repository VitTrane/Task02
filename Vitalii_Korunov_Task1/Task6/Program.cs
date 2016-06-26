using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    [Flags]
    public enum Font 
    {
        None=0,
        Bold=1,
        Italic=2,
        Underline=4
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Font font=Font.None;            
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.WriteLine("Параметры надписи: {0}", font);
                Console.WriteLine("Введите:");
                Console.WriteLine("{0,10} {1}", "1:", Font.Bold);
                Console.WriteLine("{0,10} {1}", "2:", Font.Italic);
                Console.WriteLine("{0,10} {1}", "3:", Font.Underline);

                int selectedNumber=0;
                int.TryParse(Console.ReadLine(),out selectedNumber);
                switch (selectedNumber)
                {
                    case 1:
                        font ^= Font.Bold;
                        break;
                    case 2:
                        font ^= Font.Italic;
                        break;
                    case 3:
                        font ^= Font.Underline;
                        break;
                }
            }
            
        }
    }
}
