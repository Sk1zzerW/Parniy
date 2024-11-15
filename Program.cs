using System;


class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9 };

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        int uniqueCount = numbers.Distinct().Count();

        Console.WriteLine("Четные числа " + evenCount);
        Console.WriteLine("Нечетные числа" + oddCount);
        Console.WriteLine("Уникальные числа" + uniqueCount);
    }
}
