using static System.Console;

// 52page ~

// Nullable Type

// #1. reference type 의 변수는 null 로 초기화 될수 있습니다.
string s1 = "hello";
string s2 = null; // ok	



// #2.value type 의 변수는 null 로 초기화  될수 없습니다.
// => value type 은 이름 자체가 "객체메모리" 입니다.
// => 따라서,value type 은 "데이타 없음"이란 개념이 없습니다.
int n1 = 0;
int n2 = null;	// error.


// #3. Nullable<int> 를 사용하면 int 타입도 null 사용가능
Nullable<int> n3 = null;        // ok
Nullable<double> d3 = null;     // ok

// Nullable<string> s3 = null;     // error
                                    // <> 안에는 value type 만 가능.

// #4. 편의 표기법
// => 아래 2줄은 완전히 동일합니다.
Nullable<int> n4 = null;
int? n5 = null;


// #5. Nullable 원리 - 55page n1, n2 그림 참고
int n6 = 10;

Nullable<int> n7 = null;
Nullable<int> n8 = 10;


/*
// C# 내부
struct Nullable<T>
{
    T value;       // T 타입의 값 한개 보관
    bool hasValue; // 값이 있는지 없는지 관리

}
*/