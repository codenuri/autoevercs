// 핵심 : 정수/실수 입력

// 대부분 언어의 프로그램에서 "입력" 받는 것은
// 1. "문자열" 로만 가능한것 입니다.
// 2. 입력된 문자열을 숫자 타입으로 변경해서 사용하는 것

// C언어 scanf : 입력 + 변환 작업을 함수자체가 지원
// C#          : 변환 작업은 개발자 책임

Console.Write("input yout age >> ");

string s = Console.ReadLine(); // "10"

// 입력된 "10" 이라는 문자열을 정수 10 으로 변경해서 사용
int n = Convert.ToInt32(s);

//Console.WriteLine(s * s); // error. "10" * "10" 즉, 문자열은 곱셈 안됨
Console.WriteLine(n * n); // 100 



