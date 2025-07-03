class Program
{
    /*
    public static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
    public static void Swap(ref double a, ref double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
    }
    */

    // 위 2개의 Swap 은
    // => 인자 타입만 다를 뿐 내부 구현은 동일 합니다.
    // => 이런 경우, 개발자가 직접 만들지 말고,
    // => 개발자는 "틀(template, generic)" 만 만들고
    // => 컴파일러가 함수를 만들게 하면 됩니다.

    public static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }


    public static void Main()
    {
        int n1 = 10,  n2 = 20;
        double d1 = 1.1, d2 = 2.3;
                
        Swap(ref n1, ref n2);
        Swap(ref d1, ref d2);
    }
}