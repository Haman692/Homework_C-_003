// Задача 19 Запишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int value = numberA;
int NumberB = 0;
for (int i = 0; i < 5; i++)
{
    int remaind = value % 10;
    NumberB = NumberB * 10 + remaind;
    value = value / 10;
}
if (9999 < numberA && numberA < 100000)
{
    if (numberA == NumberB)
        Console.WriteLine($"Число {numberA} являеться палиндромом");
    else
        Console.WriteLine($"Число {numberA} не являеться палиндромом");
}
else 
    Console.WriteLine($"Число {numberA} не пятизначное");