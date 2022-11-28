// Задача 19 Запишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int DateNumber(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ReverseNumber(int value)
{
    int count = 0;
    int number = 0;
    while(count < 5)
    {
        int remaind = value % 10;
        number = number * 10 + remaind;
        value = value / 10;
        count++;
    }
    return number;
}

int numberA = DateNumber("Введите пятизначное число ");
int numberB = ReverseNumber(numberA);

if (9999 < numberA && numberA < 100000)
{
    if(numberA == numberB)
        Console.WriteLine($"Число {numberA} являеться палиндромом");
    else
        Console.WriteLine($"Число {numberA} не являеться палиндромом");
}
else 
    Console.WriteLine($"Число {numberA} не пятизначное");