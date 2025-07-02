using static System.Console;

// 중요합니다. - 79 page

// C언어의 call by value 와 call by reference 개념
//         

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
//      int x = n1; // value type 이므로 복사본 생성

        MyMath.Inc1(n1); // int x = n1 의 의미이므로
                         // Inc1 에서 별도의 복사본 x 생성한다.
                         // ++x 는 복사본만 변경되고, 원본 n1 은 변경안됨

		WriteLine($"{n1}"); 
    }
}