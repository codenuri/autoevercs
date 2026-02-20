using static System.Console;

// 객체지향 언어에서 사용되는 용어 - 33page

// 핵심 : static method vs instance method

// instance method : "변수.메소드이름()" 으로 호출하는 메소드
//                   객체가 보관중인 데이타와 관련 된 기능 수행

// static method : "타입.메소드이름()" 으로 호출하는 메소드
//                 특정 데이타와는 관련없고, 타입과 연관된 기능수행

int num = 10;
// num : 변수
// int : 타입

string s = num.ToString(); // "변수이름.메소드이름()" instance method
                           // num 이 가진 값(10)과 관련된 기능수행

int ret = int.Max(10, 20); // "타입이름.메소드이름()" static method
                            // 특정값이 아닌 타입(int)자체 와 관련된 기능
// property 도 2가지 종류
Console.WriteLine(s.Length);    // s가 가진값("10") 의 길이  instance property
Console.WriteLine(int.MaxValue);// int 타입이 가질수 있는 최대값 static property
Console.WriteLine(int.MinValue);// int 타입이 가질수 있는 최소값


string s2 = "10";

// 문자열 "10" => 정수 10 으로 변경하는 2가지 방법

int n1 = Convert.ToInt32(s2); // Convert 클래스의 static 메소드 사용
int n2 = int.Parse(s2);       // int     클래스의 static 메소드 사용

Console.WriteLine(n2);