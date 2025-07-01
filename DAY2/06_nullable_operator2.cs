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


// #4. 
int[] arr = null; // 배열도 reference 타입

int n1 = arr[0];  // error
int n2 = arr?[0]; // arr != null 일때만 요소 꺼내달라.
                  // arr == null 이면 요소 접근하지 말고, null 반환
                  // error. n2 가 int 이므로 null 담을수 없다.

int? n3 = arr?[0]; // ok!!

// 핵심 : 아래 코드는 많이 사용합니다.
// 객체이름.메소드() : 객체가 null 이면 에러
// 객체이름?.메소드() : 객체가 null 이 아닐때만 호출. 
