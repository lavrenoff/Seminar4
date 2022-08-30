//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

namespace Zadacha25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int numA=Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите число B: ");
            int numB=Convert.ToInt32(Console.ReadLine());

            int result=exponentional(numA,numB);
            Console.Write($"{numA},{numB}={result}");
        }

        static int exponentional(int A,int B)
        {
            int result=1;
            for(int i=1;i<=B;i++)
            {
            result=result*A;
            }
            return result;
        }
    }
}


