using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /// <summary>
    /// Делегат методов обработки данных
    /// </summary>
    public delegate void ProcessingDelegate(long arg);
    public delegate void NotificationHandler(string message);

    class Program
    {
        private const char SEPARATOR = ';';

        public static event NotificationHandler AfterRead;
        public static event NotificationHandler AfterhWrite;

        private static string _pathInputFile = "input.txt";
        private static string _pathOutputFile = "output.txt";
        private static string _data;
        private static long _sum = 0;
        private static long _countChars = 0;        

        static void Main(string[] args)
        {
            AfterRead += ShowMessage;
            AfterhWrite += ShowMessage;

            ReadFile();
            ProcessingData();
            WriteOutputFile();

            Console.WriteLine("Для завершения приложения нажмите Enter");
            Console.ReadLine();
        }

        private static void WriteOutputFile()
        {
            using (var writer = new StreamWriter(_pathOutputFile))
            {
                string outputData = "Сумма цифр: " + _sum + ", Сумма элементов: " + _countChars;
                writer.WriteLine(outputData);
                OnAfterWrite("Запись файла завершена");
            }
        }

        private static void ReadFile()
        {
            using (var reader = new StreamReader(_pathInputFile))
            {
                _data = reader.ReadToEnd();
                OnAfterRead("Чтение файла завершено");
            }
        }

        private static void ProcessingData()
        {
            foreach (var element in _data.Split(SEPARATOR))
            {
                long number = 0;
                if (long.TryParse(element, out number))
                {
                    InvokeOperation(Sum, number);
                }
                else
                {
                    InvokeOperation(SumChars, element.Length);
                }
            }
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void OnAfterRead(string message)
        {
            if (AfterRead != null)
                AfterRead(message);
        }

        private static void OnAfterWrite(string message)
        {
            if (AfterhWrite != null)
                AfterhWrite(message);
        }

        private static void Sum(long number)
        {
            _sum += number;
        }

        private static void SumChars(long length)
        {
            _countChars += length;
        }

        private static void InvokeOperation(ProcessingDelegate operation, long arg)
        {
            operation(arg);
        }
    }
}
