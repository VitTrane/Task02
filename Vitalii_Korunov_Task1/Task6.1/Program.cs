using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Program
    {
        private static string[] _fontStyles = new string[4];

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;

            _fontStyles[0] = "None";
            bool isRepeat = true;
            while (isRepeat)
            {
                string parameters="";
                for (int i = 1; i < _fontStyles.Length; i++)
                {
                    parameters += _fontStyles[i] + " ";
                }
                if(!string.IsNullOrWhiteSpace(parameters))
                    Console.WriteLine("Параметры надписи: {0} ", parameters);
                else
                    Console.WriteLine("Параметры надписи: {0} ", _fontStyles[0]);
                Console.WriteLine("Введите:");
                Console.WriteLine("{0,10} {1}", "1:", "Bold");
                Console.WriteLine("{0,10} {1}", "2:", "Italic");
                Console.WriteLine("{0,10} {1}", "3:", "Underline");

                int selectedNumber = 0;
                int.TryParse(Console.ReadLine(), out selectedNumber);
                switch (selectedNumber)
                {
                    case 1:
                        SetParemeter(selectedNumber,"Bold");
                        break;
                    case 2:
                        SetParemeter(selectedNumber, "Italic");
                        break;
                    case 3:
                        SetParemeter(selectedNumber, "Underline");
                        break;
                }
            }
        }

        private static void SetParemeter(int numberParameter,string parametr) 
        {
            if (_fontStyles[numberParameter] == null)
                _fontStyles[numberParameter] = parametr;
            else
                _fontStyles[numberParameter] = null;
        }
    }
}
