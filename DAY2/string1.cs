// string1.cs - 43 page 이야기

// string intern pool
// => 변하지 않은 문자열을 생성하기 위해 힙에 있는 공간


// 아래 코드의 메모리 구조를 생각해 보세요
string s1 = "AAA"; // 이순간 string intern pool 에 
                   // "AAA" 문자열을 가진 객체 생성

string s2 = "AAA";  // 1. pool 에서 "AAA" 문자열 객체를 찾고
                    // => 있으면 s2 가 해당 문자열 객체 사용
                    // => 없으면 pool 에 생성

// new 를 직접 사용하면 : intern pool 이 아닌 힙 영역에 별도로 생성됩니다.
string s3 = new string("AAA");
string s4 = new string("AAA");

// 확인해 봅시다.
// => 주의 !! == 연산은 같은 객체인지 조사가 아니라
// => 같은 데이타(AAA) 인지 조사   
Console.WriteLine($"{s1 == s2}"); // true
Console.WriteLine($"{s3 == s4}"); // true

// 같은 객체인지 조사하는 방법은
// object 라는 클래스의 "ReferenceEquals()" static method 사용 - 43page
Console.WriteLine($"{object.ReferenceEquals(s1, s2)}"); // true
Console.WriteLine($"{object.ReferenceEquals(s3, s4)}"); // false
Console.WriteLine($"{object.ReferenceEquals(s1, s3)}"); // false

// object.ReferenceEquals 은 상속 배운후.. 내일 자세히 등장