using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);
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
