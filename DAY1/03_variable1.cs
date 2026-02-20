// 파이썬 변수 선언시 타입을 표기하지 않는다
// => 하나의 변수는 모든 종류의 값을 가질수 있다.
age = 10
age = "aaa"  // ok. 의도 일까 ? 실수 일까 ?
             // 안정성이 떨어진다.

// C/C++/C#/Java/Rust 등 대부분의 언어
// => 모든 변수는 타입이 있다
int age = 10;// age 는 정수만 담을수 있다
age = 20;    // ok
age = "aaa"; // error



// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';
string s = "hello";

// #2. var
var v1 = 10;		
var v2 = 3.4;		
var v3 = "hello";	

// #3. literal
int a1 = 10;		
int a2 = 0x10;		
int a3 = 0b10;		

int a4 = 1000000;	
int a5 = 1_000_000; 


