using static System.Console;

class MyMath
{
    // ref : 참조로 받는데, 함수 안에서 R/W 모두 하겠다는 의미
    //       (1번예제의 Inc2() 메소드 - ++x 는 x = x+ 1 이므로 R/w 작업)
    //       반드시 초기화된 변수만 전달 가능

    // out : 참조로 받는데, 함수안에서 W 만 하겠다(담기만하겠다는것)
    //       아래 예제
    //       초기화 되지 않아도 전달가능

    public static int AddSub(int a, int b, out int ret)
    {
        ret = a - b;
        return a + b;
    }
}

class Program
{
    public static void Main()
    {
//      int ret1 = 0;
        int ret1;       // 초기값이 없다

        int ret2 = MyMath.AddSub(5, 3, out ret1);

        WriteLine($"{ret1}, {ret2}");  // 8, 2

        // out 파라미터는 만들면서 전달도 가능
        int r1;                 // 만들고
        MyMath.AddSub(5, 3, out r1);   // 전달

        MyMath.AddSub(5, 3, out int r2); // 만들면서 전달
    }
}