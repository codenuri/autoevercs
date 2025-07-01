// mutable.cs

// mutable   : 객체의 상태를 변경할수 있는것
// immutable : 객체의 상태를 변경할수 없는것

// #1. int 타입의 객체는 mutable 합니다.
int n = 10;
n = 20;    // ok


// #2. string 타입의 객체는 immutable 합니다.

string s1 = "abcd";

char c = s1[0]; // ok
s1[0] = 'x';    // error

string s2 = s1.ToUpper();




