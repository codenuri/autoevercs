
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
    }
}
