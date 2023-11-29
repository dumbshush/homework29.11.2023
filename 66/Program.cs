// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

public class WriteN
{
    static void Main ()
    {
        Console.Write("Введите M = ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ввудите N = ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма чисел с (M = {m.ToString()}; N = {n.ToString()}) равна {PrintNumbers(m,n).ToString()}");
    }

    public static int PrintNumbers(int first, int end)
    {
        if (first == end)
        {
            return first;
        }
        return first + PrintNumbers(first+1,end);
    }
}