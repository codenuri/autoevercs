using static System.Console;

// null conditional operator ( ?, ?[]) 

string s1 = "hello";
string s2 = null;

var ret1 = s1.ToString(); // ok. 객체가 존재.
var ret2 = s2.ToString(); // 런타임에러(예외 발생)

// 메소드 호출시 안전하게 하려면
// => 아래 처럼 하면 안전합니다.
// 아래 코드는
// 1. s2 != null 이면 ret3에 메소드 반환 결과 
// 2. s2 == null 이면 메소드 호출안되고, ret3 도 null(아래 초기화 때문)
string ret3 = null;

if ( s2 != null )
{
    ret3 = s2.ToString();   
}
// 아래 한줄이 위코드와 완벽히동일
string ret4 = s2?.ToString(); // <== 아주 널리 사용되는 코드
// 1. s2 != null 이면 ToString() 메소드호출
// 2. s2 == null 이면 ToString() 메소드호출 안하고, null 반환

// 배열도 reference type
int[] arr = null;

int n1 = arr[0]; // 에러. 현재 배열 자체가 없음(null)
int n2 = arr?[0]; // 왜 에러일까요 ?
