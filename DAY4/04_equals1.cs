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
		// 객체의 동일성에는 2가지 개념이 있습니다. - 125page 그림
		// 1. 객체 자체가 동일한가 ?
		// 2. 객체는 다르지만 상태가 동일한가 ?

		// 아래 코드는 "동일한 객체" 입니다.
		Point p1 = new Point(1,2);
		Point p2 = p1;

		// 다른 객체지만 "동일 상태" 입니다.
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);
	}
}
