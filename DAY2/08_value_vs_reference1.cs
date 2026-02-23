using static System.Console;

// 핵심 : value type vs reference type


// value type : struct, enum 등의 문법으로 만든 타입
// => 모든 필드 자체가 stack 에 생성

// Reference Type : class, interface 문법으로 만든 타입
// => 모든 필드는 Heap 에 생성
// => Stack 에는 주소를 담는 변수가 생성(Reference 라는 용어 사용)

// C#, Java, Swift 는 동일

// Python : 모든 변수가 Reference 인 언어!!

// 권장
// 크기가 작은 타입은 보통 struct 로!
// 크기가 크고, 자원(파일, 네트워크등)을 많이 사용하면 class 로!

// Point : struct 권장
// People : 이름(문자열), 나이, ...  class 
// Date : struct

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}

class Program 
{
	public static void Main()
	{
		// 아래 코드는 객체를 만드는 방법이 완전히 동일하지만
		// => 메모리 구조는 완전히 달라 집니다.
		// => 36 page 그림 참고
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}
