// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Day(int getday)
{
    int friday = 5;
    if(friday >= getday)
    {
        Console.WriteLine("Это робочий день.");
    }
    if(friday < getday)
    {
         Console.WriteLine("Это выходной день.");
    }
    if(getday >= 8 || getday <=0)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    return getday;
}

int GetDay()
{
    Console.WriteLine("Введите чило соответствующее дню недели: ");
    return Convert.ToInt32(Console.ReadLine());
}

int getday = GetDay();
int day = Day(getday);
