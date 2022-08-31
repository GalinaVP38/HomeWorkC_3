// Напишите программу, которя принимает на вход число число N и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N: ");
int num  = Convert.ToInt32(Console.ReadLine());

for (int count=1; count<=num; count++)
{
    double result = Math.Pow(count,3);
    Console.Write(result+" ");
}