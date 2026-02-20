/*
// 파이썬 변수 선언시 타입을 표기하지 않는다
// => 하나의 변수는 모든 종류의 값을 가질수 있다.
// => dynamic type check 언어(실행시간 타입 조사)
age = 10
age = "aaa"  // ok. 의도 일까 ? 실수 일까 ?
             // 안정성이 떨어진다.

// C/C++/C#/Java/Rust 등 대부분의 언어
// => 모든 변수는 타입이 있다
// => static type check(정적(컴파일시) 타입 체크 언어) 안정성 !
int age = 10;// age 는 정수만 담을수 있다
age = 20;    // ok
age = "aaa"; // error
//------------------------------------------
*/

// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';     // 문자 한개는 싱글 따옴표
string s = "hello"; // 문자열은 더블 따옴표

// #2. 타입 위치에 var 사용
// => 우변의 초기값으로 컴파일러가 타입을 추론해 달라
var v1 = 10;	    // int v1 = 10	
var v2 = 3.4;	    // double v2 = 3.4
var v3 = "hello";	// string v3 = "hello"

// #3. literal
int a1 = 10;		// 10진수
int a2 = 0x10;		// 16진수
int a3 = 0b10;		// 2진수, a3 는 결국 2

int a4 = 1000000;	
int a5 = 1_000_000; // 값이 큰경우 _ 로 자리표시 가능


