using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Method_Words
{
    internal class Program
    {

        /// <summary>
        /// Получает введеное предложение с консоли и разбивает его на слова
        /// </summary>
        /// <param name="pred"></param>
        /// <returns></returns>
        static string[] SplittingStringWords(string pred)
        {
           
          
            string[] Words = pred.Split(' ');

            Print(Words);

            return Words;
        }
        /// <summary>
        /// Ввыодит на консоль слова
        /// </summary>
        /// <param name="per"></param>
        static void Print(string[] per)
        {
            foreach (string p in per)
                Console.WriteLine($"{p}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string Predlogenie = Console.ReadLine();
            SplittingStringWords(Predlogenie);



            Console.ReadKey();
        }
        
    }
}
