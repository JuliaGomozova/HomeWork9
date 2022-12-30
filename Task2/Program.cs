/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int NumbersRec(int M, int N)
{
    if (M <= N) 
    {
        return M + NumbersRec(M + 1, N);
    }
    else return 0;
}

Console.WriteLine($"Сумма чисел от {M} до {N} = {NumbersRec(M, N)}");
