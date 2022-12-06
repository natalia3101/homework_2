/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter a three-digit number");
int number = Convert.ToInt32(Console.ReadLine());

int GetSecondDigit(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
} 

if ((number > 99) && (number < 1000))
{
    Console.WriteLine($"The second digit of the number is {GetSecondDigit(number)}");
} else
{
    Console.WriteLine("Enter another number");
}
