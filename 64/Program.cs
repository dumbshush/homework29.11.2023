// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью 
// рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

public class WriteN
{
    static void Main ()
    {
        Console.Write("Введите N = ");
        int num = Convert.ToInt32(Console.ReadLine());
        int lastNum = 1;
        Console.WriteLine($"N = {num.ToString()} -> {PrintNumbers(num,lastNum)}");
    }

    public static string PrintNumbers(int first, int end)
    {
        if (first == end)
        {
            return first.ToString();
        }
        return first.ToString() + " " + PrintNumbers(first-1,end);
    }
}