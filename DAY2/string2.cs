// string2.cs

// string        : immutable 한 문자열 타입
// StringBuilder : mutable 한 문자열 타입. 

string s = "ABCD";
s[0] = 'X'; // error. immutable


// StringBuilder : 편의 표기법 없음. new 사용해야됨(45 page)
StringBuilder sb = new StringBuilder("ABCD");

sb[0] = 'X'; // ok