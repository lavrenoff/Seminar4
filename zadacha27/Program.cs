//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

namespace Zadacha25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number=Convert.ToInt32(Console.ReadLine());
            int result=SumNumber(number);
            Console.Write($"{number}={result}");  
        }

        static int SumNumber(int num)
        {
            int result=0;
            int Len=Convert.ToString(num).Length; 
            string strNum=Convert.ToString(num);

            for(int i=0;i<Len;i++)
              {
                string str=new string(strNum[i],1);
                int sNum=int.Parse(str);
                result=result+sNum;
              }
            
            return result;
        }
    }
}