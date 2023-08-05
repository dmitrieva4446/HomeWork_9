﻿/* Задача 64: 
Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
//Задача 1
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNumbers (int numberN)
{
    Console.Write(numberN + " ");
    if (numberN > 1)
    ShowNumbers(numberN - 1);
}

Console.Clear();
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"___________________");
ShowNumbers(N);