using static System.Console;

class Example
{

    // optional parameter
    // => ���ڸ� �������� ������ ����Ʈ �� ���
    // => C++/C#/Python ����
    // => Java �ȵ�.
    public void M1(int a, int b, int c = 0)
    {
    }
}

class Program
{
    public static void Main()
    {
        Example e = new Example();

        e.M1(1, 2, 3);
        e.M1(1, 2);
    }
}