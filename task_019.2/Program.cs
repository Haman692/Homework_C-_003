// Задача 19 Запишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
char [] arr = number.ToCharArray();
Console.WriteLine(arr);
char arr2 = arr.Reverse(arr2);
if (arr == arr.Reverse(arr2)) 
    Console.WriteLine("Паледроп");