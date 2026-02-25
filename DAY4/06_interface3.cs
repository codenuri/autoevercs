using static System.Console;

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
		// => 수치 타입만 가능. string 타입 안됨
		bool b1 = n1 < n2; // ok
        bool b2 = s1 < s2; // error   

		// #2. CompareTo 메소드 사용
		// => 수치타입및 string 모두 제공
		// => 크기 비교가 가능한 모든 타입에는 CompareTo 있음
		int ret1 = n1.CompareTo(n2); // n1 > n2 : 양수(1)
                                     // n1 < n2 : 음수(-1)
                                     // n1 == n2 : 0

        int ret2 = s1.CompareTo(s2);


		// M1 은 IComparable 인터페이스를 구현한 모든 타입의
		// 변수(객체)전달 가능
		M1(n1);
		M1(s1);
    }
	public static void M1(IComparable ic)
	{
	}
}
// C# 언어 특징
// => 공통으로 사용되는 이름의 메소드는
// 1. 인터페이스로 먼저 이름을 약속했고
// 2. 각 타입을 만들때 인터페이스를 구현하는 문법 사용(상속과 유사문법)
