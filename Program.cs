class Program
{
    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int prime = GetNthPrime(n);

        Console.WriteLine($"{n}-е простое число: {prime}");
    }

    static int GetNthPrime(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Значение n должно быть положительным.");
        }

        int count = 0;
        int number = 1;

        while (count < n)
        {
            number++;

            if (IsPrime(number))
            {
                count++;
            }
        }

        return number;
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
