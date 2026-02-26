class Program
{
    public static void Add<T1, T2>(T1 a, T2 b)
    {        
    }
    public static void Main()
    {
        Add(1, 1.2); // int, double
        Add(2.1, 1); // double, int

        Add<int, double>(1, 1.2);

    }
}