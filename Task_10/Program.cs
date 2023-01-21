// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0) num = - num;
if(num < 100 || num > 999)
{
    Console.WriteLine("Это не трехзначное число");
}
else
{
    int result = num % 100;
    int secondNum = result / 10;
    Console.Write(secondNum);
}