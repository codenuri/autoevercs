using static System.Console;

class MyMath
{
    public static void Inc1(int x)
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

        WriteLine($"{n1}");
    }
}