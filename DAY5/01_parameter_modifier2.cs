using static System.Console;

class MyMath
{
    // AddSub
    // 1, 2번째 인자의 합을 "반환값으로"
    // 1, 2 의 차는 3번째 인자에 담아준다

    // 아래 함수에서 
    // a, b : in parameter 라고 합니다. main 에서 보낸 값을 함수안에서 사용
    // ret  : out parameter 라고 합니다. main 에서 보낸 변수(참조)에 결과 담아줌

    public static int AddSub(int a, int b, ref int ret)
    {
        ret = a - b;
        return a + b;
    }
}

class Program
{

    public static void Main()
    {
        int ret1 = 0;  

        int ret2 = AddSub(5, 3, ref ret1); 

        WriteLine($"{ret1}, {ret2}");  // 8, 2
    }
}