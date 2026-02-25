using static System.Console;

// 사용자 정의 타입도 비교 가능하게 하려면
// => 비교 함수를 제공하면 됩니다.
// => 그런데, 다른 C# 타입과 동일한 이름을 사용하면 좋습니다.
// => IComparable 인터페이스를 구현

class Label : IComparable
{
	private string title;
	
	public Label(string s) => title = s;

    public int CompareTo(object obj)
    {
		Label other = (Label)obj;

		// 멤버가 title 한개인데, title 자체는 string 이므로
		// => CompareTo 있음
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

		// CompareTo 가 있어도
		// IComparable 구현하겠다고 표기하지 않으면
		M1(d1);  // 이 코드가 에러
	}

    public static void M1(IComparable ic)
    {
    }
}

