using System;

// C# : 컴파일 하면 "CIL" 이라는 중간언어를 생성합니다.

// CIL 를 만드는 언어는 C# 뿐아니라 VB, C++ 등도 가능합니다.
// 교재 4 page

// .net 용 언어의 공통의 데이타 타입은
// CLR(가상머신)설계시 정의 했습니다.
// => CTS(Common Type System)
// => C#, VB, C++/CLI 등의 언어의 자체 타입은 CTS 의 별명입니다.


// #1. 아래 3줄은 완전히 동일합니다.
int   n1 = 0;
System.Int32 n2 = 0;

Int32 n3 = 0;   // ok. using System 이 있으므로 이렇게도 가능.

System.int   n4 = 0;  // error.
                      // System 안에 있는것은 Int32
                      // int 는 System 안에 있는게 아닌
                      // 키워드(약속된 문자)

// "double" 은 System.Double 의 별명입니다.
// 아래 3줄은 완벽히 동일
double d1 = 0;
Double d2 = 0;
System.Double d3 = 0;

// "string" 은 System.String 의 별명
string s1 = "A";
String s2 = "A";
System.String s3 = "A";

// 29 page 표 참고