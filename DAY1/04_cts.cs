using System;

// 아래 2줄은 완벽히 동일합니다.
// => "System.Int32" 가 진짜 타입의 이름
// => int 는 별명입니다.
int          n1 = 0;
System.Int32 n2 = 0;


Int32 n3 = 0;           // ok. using System 때문에 System 생략가능
System.int   n4 = 0;    // error. int 별명. System.int 로 사용못함

// 아래 3줄도 동일
double d1 = 0;  // 별명
Double d2 = 0;  // System 생략
System.Double d3 = 0;   // 정확한 표기

// 아래 3줄도 동일
string s1 = "A"; // 별명
String s2 = "A"; // 정확한 타입
System.String s3 = "A";

// 29 page 참고