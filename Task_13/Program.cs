// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Вывод третьей цифры многозначного числа справа налево
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 0) num = -num;
// if(num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if(100 <= num && num < 1000)
// {
//     num = num % 10;
//     Console.WriteLine(num);
// }
// while(num >= 1000)
// {
//     num = (num / 100) % 10;
//     Console.WriteLine(num);
// }


// Вывод третьей цифры многозначного числа слева направо
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0) num = -num;
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if(100 <= num && num < 1000)
{
    num = num % 10;
    Console.WriteLine(num);
}
if(num >= 1000)
{
    while(num >= 1000)
    {
        num /= 10;
    }
num %= 10;
Console.WriteLine(num);
}