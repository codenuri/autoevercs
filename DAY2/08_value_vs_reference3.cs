using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		// 아래 3줄에 대한 메모리 그림 - 39 page
		CPoint cp1; // 참조 변수만 생성. x, y 는 없음
		SPoint sp1; // new 없지만 스택에 x, y 있음. 그런데, 생성자 호출안됨
		SPoint sp2 = new SPoint(1, 1); // ok. stack 객체 만들고 생성자호출
		
		// 핵심 : 에러를 모두 찾으세요
		int a = cp1.x;	// error
		cp1.x = 2;		// error

		int b = sp1.x;	// error. 초기화 안됨
		sp1.x = 2;		// ok
		int c = sp1.x;	// ok

		int d = sp2.x;	// ok
		sp2.x = 2;		// ok

	}
}
