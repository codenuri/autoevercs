
// #1. int.Parse() : 실패시 예외 발생
// => 예외를 처리하려면 exception6.cs 예제 참고

int n1 = int.Parse("10");    // ok. 성공
int n2 = int.Parse("Hello"); // 실패. 예외 발생


// #2. int.TryParse() : 성공/실패 여부를 반환값으로 전달
// => 변환 결과는 2번째 인자에 담아 줍니다.

// 메소드가 내부적으로 R/W 모두 해야 한다 => ref 로 설계
// 메소드가 내부적으로 W 만 하면 된다 => out 로 설계

// TryParse : 2번째 인자에 담아주기만 하면 된다. out 으로 설계됨
int n3 = 0;
bool b1 = int.TryParse("10", out n3);
bool b1 = int.TryParse("10", out int n4);

// C# AAA 메소드가 실패 가능성이 있다면 실패시 : 예외 발생
// TryAAA 가 있다면 : 예외가 아닌 반환값(bool)의 전달
//                   결과는 out 파라미터로