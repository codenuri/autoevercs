using static System.Console;

/*
class Object
{
	public virtual bool Equals(Object obj)
	{	
		// Object 를 만들때는 Point 클래스 를 알수 없습니다.
		// => 그래서 여기서 동일 상태 를 조사하는 코드는 만들수 없습니다.
		// => 그래서 기본 구현은 "동일 객체" 조사
		// => "동일 상태 조사"가 필요하면 파생 클래스(Point) 설계자가
		//     override 해서 하라는 의미

		// 아래 처럼 되어 있습니다.
		// => == 연산 사용하므로 "동일 객체" 조사
		// return obj == this(자기자신)
	}
}
*/

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object obj)
    {
		// Object 타입으로는 x, y 접근 안되므로 Point 타입으로 캐스팅후조사
        Point pt = (Point)obj;

		// 상태로 동일성 조사
		return pt.x == x && pt.y == y;	
    }
}

class Program
{
	public static void Main() 
	{
		// 객체의 동일성에는 2가지 개념이 있습니다. - 125 page
		// 1. 객체 자체가 동일한가 ?
		// 2. 객체는 다르지만 상태가 동일한가 ?

		Point p1 = new Point(1,2);
		Point p2 = p1;

		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// #1. == 연산자를 사용한 동일성 조사
		// => 동일 객체 조사 
		Console.WriteLine($"{p1 == p2}"); // True
        Console.WriteLine($"{p3 == p4}"); // False


        // #2. Object 클래스가 제공하는 Equals() 메소드

		// Object 클래스 기본 구현 : 동일 객체 조사
		// Point 클래스에서 override : 동일 상태 조사
		// => 일반적으로 널리 사용되는 기술(Java 도 거의 유사)
        Console.WriteLine($"{p1.Equals(p2)}");
        Console.WriteLine($"{p3.Equals(p4)}");
    }
}
