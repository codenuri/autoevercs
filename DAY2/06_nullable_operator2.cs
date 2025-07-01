using static System.Console;

// null conditional operator ( ?, ?[]) 

string s1 = "hello";
string s2 = null;

// #1. null 인 객체의 메소드를 호출하면 에러 입니다.
var ret1 = s1.ToString(); // ok. 객체가 존재.
//var ret2 = s2.ToString(); // 런타임에러(예외 발생)


// #2. 안전하게 사용하려면 확인후 호출하면 됩니다.

if ( s2 != null )
{
    var ret3 = s2.ToString();
}

// #3. 핵심. 아래 한줄이 위 코드의 의미 입니다.
var ret4 = s2?.ToString();

// s2 != null 이면 s2.ToString() 실행후 결과를 ret4에 넣기
// s2 == null 이면 s2.ToString() 실행안함, ret4 에는 null 들어감.
// 즉, s2 가 null 이 아닐때만 메소드 호출해 달라.


