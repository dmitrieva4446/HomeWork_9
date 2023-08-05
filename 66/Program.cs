/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumMN(int M, int N)
{
    int sum = M;
    if (M == N) return 0;
    else
    {
        M++;
        sum = M + SumMN(M, N);
        return sum;
    }
}

Console.Clear();
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"_______________________________________________________________");
Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} равна {SumMN(M - 1, N)}.");