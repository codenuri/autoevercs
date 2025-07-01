using static System.Console;

// 사용자에게 double 값 한개를 입력받아서 화면 출력해 보세요

string s = Console.ReadLine(); // 3.14 입력하면
                               // "3.14" 문자열이 입력된것

double d = double.Parse(s);

WriteLine($"{d}");


// 위 코드는 실전에서는 아래 처럼 단순하게
double d1 = double.Parse( Console.ReadLine() ); 



