using static System.Console;

// value type     : 스택에 값을 보관
// reference type : 힙에 값을 보관, stack 에서 힙을 가리키는 것(포인터변수)


// #1. reference type 의 변수는 null 로 초기화 될수 있습니다.
// => 값 없음을 표현할때 사용
string s1 = "hello";
string s2 = null; // ok	

// #2.value type 의 변수는 null 로 초기화  될수 없습니다.
int n1 = 0;     // ok
int n2 = null;	// error.

// 그래서, value type 은 "값 없음"을 표기할수 없었습니다.
// C#2.0 부터 value type 도 값 없음을 표현하기 위해 Nullable 도입

Nullable<int> n3 = null; // ok. null 가능한 int


