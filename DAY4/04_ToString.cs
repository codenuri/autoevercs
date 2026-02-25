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
