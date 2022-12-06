/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
string numberStr = Convert.ToString(number);
if (numberStr.Length > 2)
{
    Console.WriteLine($"Third number is {numberStr[2]}");
} else 
{
    Console.WriteLine("No third number");
}

// не знаю, как решить это через математику, ведь неизвестно, какое число будет вводится