
using static System.Console;
// ToString() 메소드는 object 클래스가 제공합니다.
/*
class object
{
	public virtual string ToString()
	{
		// 기본 구현은 현재 객체의 타입이름을 문자열로 반환
	}
}
*/

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);

	// 기반 클래스의 가상 메소드인 ToString()를 override 해서
	// 타입의 이름이 아닌 자신의 상태를 문자열로 반환
    public override string ToString()
    {
		string s = $"x = {x}, y = {y}";

		return s;
    }
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1, 2);

		string s = p.ToString();

		WriteLine(s);

		WriteLine(p); // 이렇게 바로 보내도 됩니다.
					  // 내부적으로 p.ToString() 으로 출력
    }
}

// 핵심 : 기반 클래스가 가상함수(object)가 있으면
// => 파생 클래스는 override 안해도 사용가능 - 기본 구현 사용
// => 기본 구현을 변경하려면 override 하면 됩니다.