// Задача 19 Запишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int revNumber = number;
string strNumber = revNumber.ToString();
char[] arrNumber = strNumber.ToCharArray();
Array.Reverse(arrNumber);
strNumber = new string(arrNumber);
revNumber = Convert.ToInt32(strNumber);

if(number == revNumber)
    Console.WriteLine($"Число {number} являеться палиндромом");
else
    Console.WriteLine($"Число {number} не являеться палиндромом");