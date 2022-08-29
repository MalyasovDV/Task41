int CountPositiveNumbers(int m)
{
    int a, count = 0;

    for (int i = 0; i < m; ++i)
    {
        a = int.Parse(Console.ReadLine());
        if (a > 0)
            ++count;
    }

    return count;
}

int m;
m = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + CountPositiveNumbers(m));