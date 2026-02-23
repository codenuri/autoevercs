// 아래 2줄은 완전히 동일!!
// => 하지만 타입에 따라서 new와 단축 표기법의 동작이 다른 경우가 있다
int n1 = 0;
int n2 = new int();

// 메모리에 "AAA" 라는 문자열이 몇개 있을까요 ?

string s1 = "AAA";  // string intern pool 에 있는 문자열 가리키게 됩니다.
string s2 = "AAA";  // 이 코드도 s1 과 같은 주소를 가리키게 됩니다.

// 그런데, 아래 처럼하면 string intern pool 을 사용하지 않고
// 개별 메모리 사용하게 됩니다. 권장 안함.
string s3 = new string("AAA");
string s4 = new string("AAA");

// 2개가 같은 메모리 주소를 가리키는지 조사하는 방법
Console.WriteLine($"{object.ReferenceEquals(s1, s2)}"); // true
Console.WriteLine($"{object.ReferenceEquals(s1, s3)}"); // false
Console.WriteLine($"{s1==s3}"); // true, 같은 객체(동일주소)인지가 아니라
                                //       같은 문자열인가  조사

// StringBuilder : 변경가능하므로, 공유 할수 없습니다.

// 변경 불가능하면
// 1. 동일 데이타의 공유 가능
// 2. 여러개 CPU 에서 동시접근해도 문제 없음(멀티 코어에 최적화됨)
// 3. 컴파일러가 다양한 방법으로 최적화가능

// 변경할 필요 없는 문자열
// => 무조건 string 사용
// => StringBuilder 사용해도 되지만, 성능이 나쁘고, 동시접근시 동기화 필요

// Rust: 모든 변수는 기본적으로 immutable
// let n = 10;
// n = 20; // error

// let mut n = 10; // 변경하겠다고 표기
// n = 20; // ok