using static System.Console;

class MyMath
{
    public static void Inc1(int x)
    {
        ++x;
    }
    public static void Inc2(ref int x) // Inc2(int* x)
    {
        ++x;
    }
}

class Program
{
    public static void Main()
    {
        int n1 = 0;
        int n2 = 0;

        MyMath.Inc1(n1);
        MyMath.Inc2(ref n2); // C 언어 Inc2(&n2)

        WriteLine($"{n1} {n2}"); // 0, 1
    }
}