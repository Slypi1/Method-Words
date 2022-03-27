using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5__Rearrangement_of_words
{
    internal class Program
    {
        /// <summary>
        /// Разделяет введенное предложение из консоли на массив слов
        /// </summary>
        /// <param name="pred"></param>
        /// <returns></returns>
        static string[] SplittingStringWords(string pred)
        {


            string[] Words = pred.Split(' ');



            return Words;
        }
        /// <summary>
        /// Ввывод введенного предложение из консоли в обратном порядке
        /// </summary>
        /// <param name="str"></param>
        static void ReversWords (string str)

        {

            string[] ResultString = SplittingStringWords (str);

            string NewString= " ";
             for (int i = ResultString.Length; i >0; i--)
                  NewString += ResultString[i-1]+ " ";
               
              

            Console.Write($"Новое предложение:{NewString}");

        }


        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string Predlogenie = Console.ReadLine();
            ReversWords(Predlogenie);
            Console.ReadKey();
        }
    }
}
