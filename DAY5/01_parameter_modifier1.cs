using static System.Console;

// 중요한 개념 - 79 page

class MyMath
{
    // int 는 value 타입이므로
    // main 에서 전달한 n1 의 복사본 x 생성
    public static void Inc1(int x)
    {
        ++x;  // 복사본 증가  
    }

    // ref 인자 : 복사본을 만들지 말고, 
    //           참조(주소)로 받으라는 의미
    public static void Inc2(ref int x) // C 언어 : (int* x)
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
        MyMath.Inc2(ref n2);  // C 언어: Inc2(&n2)

        WriteLine($"{n1}, {n2}"); // 0, 1
    }
}
