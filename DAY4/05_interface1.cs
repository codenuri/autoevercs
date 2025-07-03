using static System.Console;

// 언제 추상클래스를 사용하고, 언제 인터페이스를 사용하나요 ?

// 도형 편집기 Shape
// => 모든 도형은 color 같은 멤버 필요 합니다.
// => 추상 클래스가 좋습니다.

// 인터페이스
// => 함수 이름만 약속하고 싶을때
// => interface1 ~ 2 예제



class Program 
{
	public static void Main()
	{
		int n1 = 10;
		int n2 = 20;

		string s1 = "AAA";
		string s2 = "BBB";

		// 두 변수의 크기를 비교하는 방법. 

		// #1. 비교 연산자(<, >,...) 사용
		// => 정수, 실수 같은 숫자 타입만 가능
		bool b1 = n1 < n2; // ok
		bool b2 = s1 < s2; // error

		// #2. CompareTo 메소드 사용
		// => C# 에서 비교 가능한 모든 타입에는 CompareTo 메소드 있습니다.
		int ret1 = n1.CompareTo(n2); // n1 > n2 라면 양수 반환 (1 )
									 // n1 < n2 라면 음수 반환 (-1)
									 // n1 == n2 라면 0
		int ret2 = s1.CompareTo(s2);

    }




    public static void M1(IComparable ic)
	{
	}

}
