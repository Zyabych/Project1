using System;
using System.Threading;

namespace Lecture_1_5_Medlev_Pavel
{
    /// <summary>
    ///  Консольное приложение для бегущей строки
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Всё неизменяемое в константы.
            const string infoText = "Количество отображаемых символов в строке = {0}. Задержка = {1} мс. /esc- выход/";
            // TODO Магия упр. последовательностей. А можно было просто   Console.SetCursorPosition(9, 3)
            //const string startPoint = "\n\n\n\n\t\t\t ";
            const string textStr1 = "  Московское время  ";
            const string textStr2 = ". Время как вода - течет и изменяется.. ";

            Console.ForegroundColor = ConsoleColor.Green;

            // TODO снова константы
            const int lengthDisplayBox = 70;
            const int delayTime = 500;
            int i = 0;
            int lengthLineBreak = 0;

            do
            {
                Console.WriteLine(infoText, lengthDisplayBox, delayTime);
                Thread.Sleep(delayTime * 8);
                Console.Clear();

                while (!Console.KeyAvailable)
                {
                    // TODO Конкатенация через +. Почему для infoText у вас шаблон а тут +???
                    string textBox = string.Format("{0}{1}{2}", textStr1, DateTime.Now.ToLongTimeString(), textStr2);

                    Console.SetCursorPosition(12, 3);
                    Console.Write($"{textBox.Substring(i, lengthDisplayBox - lengthLineBreak)}{textBox.Substring(0, lengthLineBreak)}");
                    Thread.Sleep(delayTime);
                    Console.Clear();

                    // TODO Неправильное использование итератора. Необходимо было объединять.
                    // i++
                    if (++i == textBox.Length)
                    {
                        i = 0;
                        lengthLineBreak = 0;
                    }

                    else if (i == textBox.Length - lengthDisplayBox + lengthLineBreak)
                        lengthLineBreak++;
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}