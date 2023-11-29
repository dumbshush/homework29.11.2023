// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввудите N = ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);

Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction (m, n - 1));
    }
    else
    {
        return 0;
    }
}
