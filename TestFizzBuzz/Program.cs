public static class FizzBuzz {

    public static void GenerateListFizzBuzz()
    { 
        for (int i = 1; i < 101; i++)
        {
            PrintFizzBuzz(i);
        }
    }

    public static void PrintFizzBuzz(int n)
    {
        bool isMultThree = IsMultThree(n);
        bool isMultFive = IsMultFive(n);

        if (isMultFive && isMultThree)
        {
            Console.WriteLine("FizzBuzz");
        }
        if (isMultThree)
        {
            Console.WriteLine("Fizz");
        }
        if (isMultFive)
        {
            Console.WriteLine("Buzz");
        }
        if (!isMultFive && !isMultThree)
        {
            Console.WriteLine(n);
        }
    }

    public static bool IsMultThree(int n)
    {
        return n % 3 == 0;
    }

    public static bool IsMultFive(int n)
    {
        return n % 5 == 0;
    }
}