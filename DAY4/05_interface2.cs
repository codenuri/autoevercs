using static System.Console;




// 사용자 정의 타입에 대해서 CompareTo 를 제공하려면
// => 그냥 구현만 제공해도 되지만..

// 다른 C# 타입과의 호환성을 위해
// 1. IComparable 로 부터 상속 받으세요
// 2. 규칙인 "CompareTo" 구현하세요

class Label :  IComparable
{
	private string title;
	
	public Label(string s) => title = s;


    public int CompareTo(object? obj)
    {
		Label other = (Label)obj;

		// Label 의 title 필드 자체는 string 인데
		// string 자체는 CompareTo 가능..
		return title.CompareTo(other.title);
    }
}



class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		// 사용자 정의 타입인 Label 도 크기 비교가 되도록 해봅시다.
		int ret = d1.CompareTo(d2);
	}

    public static void M1(IComparable ic)
    {
    }
}


// 참고
// C++ : 다중 상속 가능
// C#/Java/Python : 다중 상속 안됨. 다중 인터페이스 상속가능

// Rust : 상속 문법없음(Traits 라는 독특한 기술 사용)