/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter a number from 1 to 7");
string numberStr = Console.ReadLine() ?? "";
int number = Convert.ToInt32(numberStr);

if ((number == 6) || (number == 7)) 
    Console.WriteLine("yes");
else if ((number == 1) || (number == 2) || (number == 3) || (number == 4) || (number == 5)) 
    Console.WriteLine("no");
else 
    Console.WriteLine ("enter another number");
