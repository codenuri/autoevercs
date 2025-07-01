using static System.Console;

// 객체지향 언어에서 사용되는 용어

// 33 page
// 핵심 : static method vs instance method

// instance method : "변수이름.메소드이름()" 으로 호출하는 메소드
//                   객체가 보관중인 데이타와 관련 된 기능 수행

// static method : 타입.메소드이름() 으로 호출하는 메소드
//                 특정 데이타와는 관련없고, 타입과 연관된 기능수행

int num = 10;

string s1 = num.ToString(); // "변수이름.메소드이름()"
                            // => 변수가 가진 데이타에 관련된 작업

int ret   = int.Max(10, 20); // "int" 는 변수이름이 아닌 타입이름
                             // => 특정 변수의 데이타가 아닌
                             //    타입에 관련된 작업 수행.

// property 도 instance property , static property 가 있습니다.
string s2 = "ABCD";

WriteLine($"{s2.Length}");    // "ABCD" 의 길이이므로 4
WriteLine($"{int.MaxValue}"); // int 타입이 가질수 있는 최대값
WriteLine($"{int.MinValue}");

// example : 정수 입력 받기

// #1. 먼저 문자열로 입력 받은후
string s3 = Console.ReadLine();

// #2. 문자열을 정수로 변경해야 한다. ("10" => 10
// => int 관련 작업이므로

int n3 = int.Parse(s3);
        // => s3 가 정수로 변경할수 없는 데이타 라면 
        //    runtime error(예외)

// 위 예제가 2개의 static method 를 사용하고 있습니다.
// Console.ReadLine() : Console 클래스의 static method
// int.Parse(s3)      : int 클래스의 static method