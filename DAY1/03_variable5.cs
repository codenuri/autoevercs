using static System.Console;

// 03_variable5.cs

// #1. 변수값 출력 방법(9 page)
int a = 3;
double b = 3.4;

// 1. 변수값 한개 출력

Console.WriteLine(a); // 3


// 2. 여러개 변수를 서식에 맞게 출력
Console.WriteLine("a = {0}, b = {1}, a = {0}", a, b);


// 3. C# 6.0 부터 보간문자열($로시작하는 문자열, Interpolated string) 사용가능

Console.WriteLine($"a = {a}, b = {b}, a+b = {a + b}");

// 참고 : 파이썬
//println("a = {0}, b = {1}, a = {0}" % (a, b));





// #2. casting 이야기
int n1 = 0;     // n1 정수를 담는 4바이트 크기 "박스"

n1 = 3.4; // ? 





// nameof
int color = 100;
string s = "abcd";
string name = nameof(color);

WriteLine($"{nameof(color)} : {color}");				
*/


