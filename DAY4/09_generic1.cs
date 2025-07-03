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
                
        // #1. generic method 를 사용하는 정확한 방법
        Swap<int>(ref n1, ref n2);  // 1. 틀을 사용해서 int Swap(int, int) 함수 생성
                                    // 2. 이 위치는 call Swap(int, int) 의 의미 기계어

        Swap<double>(ref d1, ref d2);// 1. 틀을 사용해서 double Swap(double, double) 함수 생성
                                     // 2. 이 위치는 call Swap(double, double) 의 의미 기계어

        // #2. 타입 인자를 생략하면 인자의 타입을 보고 컴파일러가 추론
        Swap(ref n1, ref n2); // n1 을 보고 T = int 라고 추론
        Swap(ref d1, ref d1); // d1 을 보고 T = double 라고 추론

        // 그래서 실전에서는 #2 사용(간결하니까)

    }
}