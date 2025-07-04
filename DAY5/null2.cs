// 프로그램에서 "name" 변수가 필요하다.
// 그런데, 프로그램 특성상 name 은 항상 유효한 값을 가지게 된다.
// => null 불가능한 타입이 좋다.
// => 그런데, string 은 참조 타입이므로 항상 null 가능하다.

// C# 1.0 ~ 8.0 : 모든 reference type 은 null 이 가능하다.

// C# 9.0 : reference 타입도 null 가능/불가능으로 구분

string  s1 = null; // null 불가능 타입
string? s2 = null; // null 가능 타입