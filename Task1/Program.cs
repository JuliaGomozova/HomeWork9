/*
 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int num = N;

string NumbersRec(int num, int N)
{
    if (num > 0) 
        return $"{num} "+ NumbersRec(num -1, N);
    else 
        return String.Empty;
}

Console.WriteLine(NumbersRec(num, N));
