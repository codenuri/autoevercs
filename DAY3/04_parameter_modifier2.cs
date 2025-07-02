using static System.Console;

class MyMath
{
    // AddSub
    // 1, 2 인자의 합은 반환값으로
    // 1, 2 인자의 차는 3번째 인자에 담아 줄께.
    // ref : R/W 를 모두 하겠다는 의미, 
    //       초기화된 변수만 전달 가능

    // out : W 만 하겠다는 의미
    //       초기화 되지 않은 변수도 가능

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
//      int ret1 = 0;  // 초기화된 변수
        int ret1;      // 초기화된 안된 변수

        int ret2 = AddSub(5, 3, out ret1);  // ???

        WriteLine($"{ret1}, {ret2}"); 
    }
}