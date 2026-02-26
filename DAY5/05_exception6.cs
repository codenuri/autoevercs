
int age = 0;

Console.Write("나이를 입력해 주세요 >> ");

string s = Console.ReadLine();   // "aa" 입력해 보세요

age = int.Parse(s);

Console.WriteLine($"입력된 나이는 {age} 입니다");