string name1 = "ABC";
string name2 = null;

var n1 = name1.Length; // ok
var n2 = name2.Length; // 실행시간 에러 발생

// null 인 객체를 사용하는 것은 "아주 위험합니다"
// 안전한 코드를 사용하려면 null 을 사용하지 말고, 항상 값을 가지게 하면됩니다

// value type : 
// int  : null 가질수 없다.
// int? : null 가질수 있다
// => 사용자가 null 을 사용할지 말지를 선택할수 있다
// => 안전한 코드가 필요하면 int? 사용하지 말자

// reference type
// => ~ C#8.0    : 항상 null 이 될수 있다
// => C#9.0 이후 : reference type 도 null 가능, 불가능을 선택할수 있다

string  s3 = null; // ~ C#8.0 까지는 아무 문제 없는 코드
                   // C#9.0 부터는 null 불가능 문자열

string? s4 = null; // null 가능   문자열

// C# 9.0 이후에 Reference 타입도 ? 를 사용하자는 개념 추가
// => 사용하지 않아도 에러는 아님.
// => 경고로 처리

// 이문법을 사용하지 않으면
// => 프로젝트 설정에서 "<nullable>" 항목을 disable 로 변경