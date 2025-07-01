// 편의표기법.cs

// 1. C# 에서 모든 객체(변수)는 "new" 로 만들어야 합니다.
// => ValueType 이건, Refernce Type 이건 모두
CPoint cp = new CPoint(1, 2); // class
SPoint sp = new SPoint(1, 2); // struct


// #2. int, string 도 마찬가지 입니다.
// => 즉 아래 표현이 정확한 표기법
int n1 = new int();
string s1 = new string("ABCD");

// #3. 그런데, int, double, string 같은 표준 타입에 한해서는
// 편하게 사용할수 있는 "편의 표기법" 을 제공합니다.
int n2 = 0;
string s2 = "ABCD";

// #4. new 를 사용하는 것과 편의 표기법을 사용하는 것이
// 완전히 동일한가요 ??
// => 타입에 따라 다릅니다.
// => int 는 동일
// => string 은 다릅니다.

// #5. 그럼 어떻게 합니까 ?
// => 편의 표기법이 좋습니다.(최적화 잘 지원.. )