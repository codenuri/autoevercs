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

    // 구현은 유사(동일)한데, 단지 타입만 다른 여러개의 함수가 필요하면
    // => 개발자가 직접 여러개를 만들지 말고
    // => 개발자는 "함수" 가 아닌 "함수의 틀"을 만들면 됩니다.
    // C++ : 틀 이라는 관점을 강조해서 "template" 이라는 용어 사용
    // C#, Java, Rust : 모든 타입에 동작한다 라는 관점을 강조해서 일반화(Generic) 이라는용어사용
    public static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int    n1 = 10,  n2 = 20;
        double d1 = 1.1, d2 = 2.3;
                
        Swap<int>(ref n1, ref n2);  // 컴파일러가 하는 일
                                    // 1. 틀을 사용해서 Swap(ref int, ref int) 버전함수 생성
                                    // 2. 이 위치는 "call Swap(ref n1, ref n2)" 

        Swap<double>(ref d1, ref d2); // 1. 틀을 사용해서 Swap(ref double, ref double)함수 생성
                                      // 2. 이 위치는 "call Swap(ref d1, ref d2)" 

        // Generic 함수를 사용하는 방법
        // 1. 타입 인자를 명시적으로 전달 - 위 코드
        // 2. 타입 인자 생략 - 함수 인자로 컴파일러가 추론
        Swap(ref n1, ref n2); // n1, n2 를 보고 int 로 추론
        Swap(ref d1, ref d2);
    }
}