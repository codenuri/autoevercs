// github.com/codenuri/autoevercs   DAY2.zip 받으시면 됩니다.

using static System.Console;

// 교재 31 page.
// 핵심
// => C# 의 모든 변수는
// 1. 데이타(값)을 저장하고
// 2. 데이타 관련 메소드(method, 함수)를 제공하고
// 3. 데이타 관련 속성(property) 를 제공한다.

// #1. 모든 변수는 데이타를 저장한다
int n = 10;
string s = "abcd";


// #2. 모든 변수는 자신이 저장한 데이타 관련 메소드(함수)를 제공한다.

string s1 = n.ToString(); // n 이 가진 숫자(데이타)를 문자열로 반환해달라
bool b = s.Contains('a'); // s 의 문자열(데이타) 안에 'a' 문자가 있는가?

WriteLine($"{s1}"); // "10"
WriteLine($"{b}");  //  true


// #3. 모든 변수는 자신이 저장한 데이타 관련 속성(property) 제공한다.

bool b3 = s.Contains('a'); // 메소드는 () 를 사용합니다.
int  n3 = s.Length;        // 속성(Property) 는 ()가 없습니다.

// 메소드 : 함수 이름로 인자를 전달할수 있습니다. 동작관련 기능
// 속성   : 인자를 전달할수 없습니다. 단지, 데이타에 대한 단순정보를 얻을때사용
//         "정확한 속성이 뭔지는 class 문법배울때"
//         C# 언어만 가진 고유의 특징.

// example
string s5 = "  AAABB  ";

// s5 의 앞뒤 공백을 제거한 문자열을 얻고 싶다.
string s6 = ?;

WriteLine($"{s5}"); // "  AAABB  "
WriteLine($"{s6}"); // "AAABB"




