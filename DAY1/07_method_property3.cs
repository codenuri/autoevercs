using static System.Console;

// 사용자에게 실수(double) 값 한개를 입력받아서 화면 출력해 보세요

// 1. 문자열 형태로 입력 받을수 밖에 없습니다.

// 2. 입력된 문자열("3.4") => double 변수로 변경

// 3. double 변수 출력

string s = Console.ReadLine(); // "3.4"

// "3.4" => 3.4
// Convert 타입 또는 double 의 static 메소드

double d1 = double.Parse(s);
double d2 = Convert.ToDouble(s);

Console.WriteLine(d1);
Console.WriteLine(d2);