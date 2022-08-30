//Задача 29: Напишите программу, которая задаёт массив из введенного числа 
//и выводит их на экран.
//пользователь вводит число элементов в массиве и минимальное, 
//и максимальное значение . надо заполнить массив рандоными данными 
//от минимального до максимального значение .И важное уточнениее , 
//делать все в методе который возвращает массив
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

namespace Zadacha29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов: ");
            int massivLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минимальное значение числа: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение числа: ");
            int max = Convert.ToInt32(Console.ReadLine());

            if (min < max)
            {
                int[] numbers = new int[massivLength];
                ZapolRandom(numbers, min, max);
                Vivod(numbers);
            }
            else
                Console.Write("Минимальное значение должно быть меньше максимального значения, исправьте пожалуйста!");



        }

        static void ZapolRandom(int[] massiv, int min, int max)
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = new Random().Next(min, max);
            }
        }

        static void Vivod(int[] massiv)
        {
            string str1 = "";

            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    str1 = str1 + Convert.ToString(massiv[i]);
                else
                    str1 = str1 + Convert.ToString(massiv[i]) + ", ";
            }

            Console.Write($"{str1} -> [{str1}]");
        }
    }
}