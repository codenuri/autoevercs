using static System.Console;

/*
class Object
{
	public virtual String ToString()
	{
		// 자신의 타입을 조사해서
		// 문자열로 반환하는 코드 
		// return "내타입의이름"
	}
}
*/

// ToString() 메소드
// => 디버깅 등을 위해 객체의 상태를 문자열로 반환 하는 용도로 사용하는 메소드
// => Object 기본 구현은 "타입 이름" 반환
// => 보통 클래스 만드는 사람이 override 해서 자신의 상태를 반환하도록 변경
/*
class Object
{
	// virtual method - 3개
	// => 클래스 설계자가 다시 만들어도 된다는 의미

	// non-virtual
	// => 다시 만들지 말고, 제공해주는 기능을 사용해라
	// => GetType() 등
}
*/

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);

    public override string ToString()
    {
		// 자신의 상태를 문자열로 만들어서 반환
		// => $ 문자열을 WriteLine() 뿐 아니라 아래 처럼도 사용가능

		string s = $"x={x}, y={y}";
		return s;
    }
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1, 2);
		
		// 객체 p의 상태(x, y) 를 화면에 출력해 보고 싶다
		// => 이런 용도로 사용하라고 Object 제공하는 메소드가 "ToString()"
		// => 객체의 상태를 "문자열"로 반환하는 의미를 가진 메소드

		string s = p.ToString();

		WriteLine(s);
    }
}
