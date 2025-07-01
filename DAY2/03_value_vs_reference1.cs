using static System.Console;

// java 아시는 분은 와 동일한 개념입니다.

// Value Type vs Reference Type 

// C# 의 모든 타입은 "class" 또는 "struct" 문법으로 만들어집니다.

// class  로 만든것 : Reference Type
// struct 로 만든것 : Value Type

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
		// #1. 아래 2줄은 동일한 방법으로 객체를 생성합니다.
		// => 그런데, 메모리 구조가 완전히 다릅니다.
		// => 교재 "36page" 그림이 중요
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);


		string s = "AA";
	}
}

// stack
// => 크기가 작습니다.(보통 1MB)
// => 할당/해지 속도가 아주 빠릅니다.
// => 차례대로 사용하고, 역순으로 파괴 됩니다.
// => 크기가 작고, 자주 만들게 되는 객체(변수)가 이곳을 사용




// 힙
// => 크기가 큽니다.(부족하는 자동증가, 대부분 1G 이상)
// => 할당/해지 속도가 stack 보다 느립니다.
// => 할당/해지가 자유롭습니다.
// => 크기가 크고, 한번 만든후 오랜동안 사용하게 되는 객체

// C/C++
// => 타입의 설계자가 아닌 사용자가 메모리 위치 결정
// int n = 0;           // 스택에 만들어 달라.
// int* p = new int(0); // 힙에 만들어 달라.

// 그런데, 어떤 타입(int, Rect 등)의 크기는
// => 타입 사용자 보다 설계자가 정확히 알고 있다.


// C#/Java/Swift
// => 타입의 설계자가 변수(객체)의 메모리 위치 결정
// struct 로 만든 타입 : 모든 객체는 스택에 생성. value type
// class  로 만든 타입 : 모든 객체 자체는 힙 생성. stack  에는
//						힙객체를 가리키는 변수(포인터, 참조) 생성
//						reference type