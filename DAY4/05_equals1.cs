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

        Console.WriteLine($"{p1.Equals(p2)}");
        Console.WriteLine($"{p3.Equals(p4)}");
    }
}
