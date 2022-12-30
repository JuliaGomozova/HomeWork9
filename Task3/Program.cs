/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int A(int n, int m)
{
    if (n == 0)
        return m+1;
    else
    {
        if (m == 0)
        return A(n - 1, 1);
    }
    return A(n-1, A(n, m -1));
}


int n = GetNumber("Введите n >= 0:");
int m = GetNumber("Введите m >= 0:");
Console.WriteLine($"функция Аккермана А({n},{m}) = {A(n,m)}");