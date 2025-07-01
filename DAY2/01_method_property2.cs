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

WriteLine($"{s2.Length}");
WriteLine($"{int.MaxValue}");
WriteLine($"{int.MinValue}");