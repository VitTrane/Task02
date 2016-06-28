using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            string[] fontStyles = new string[4];
            fontStyles[0] = "None";
            bool isRepeat = true;
            while (isRepeat)
            {
                string parameters="";
                for (int i = 1; i < fontStyles.Length; i++)
                {
                    parameters += fontStyles[i] +" ";
                }
                if(!string.IsNullOrWhiteSpace(parameters))
                    Console.WriteLine("Параметры надписи: {0} ", parameters);
                else
                    Console.WriteLine("Параметры надписи: {0} ", fontStyles[0]);
                Console.WriteLine("Введите:");
                Console.WriteLine("{0,10} {1}", "1:", "Bold");
                Console.WriteLine("{0,10} {1}", "2:", "Italic");
                Console.WriteLine("{0,10} {1}", "3:", "Underline");

                int selectedNumber = 0;
                int.TryParse(Console.ReadLine(), out selectedNumber);
                switch (selectedNumber)
                {
                    case 1:
                        if (fontStyles[selectedNumber] == null)
                        {
                            fontStyles[selectedNumber] = "Bold";
                        }                            
                        else
                            fontStyles[selectedNumber] = null;
                        break;
                    case 2:
                        if (fontStyles[selectedNumber] == null)
                            fontStyles[selectedNumber] = "Italic";
                        else
                            fontStyles[selectedNumber] = null;
                        break;
                    case 3:
                        if (fontStyles[selectedNumber] == null)
                            fontStyles[selectedNumber] = "Underline";
                        else
                            fontStyles[selectedNumber] = null;
                        break;
                }
            }
        }
    }
}
