
int age = 0;

Console.Write("나이를 입력해 주세요 >> ");

string s = Console.ReadLine();   // "aa" 입력해 보세요

try
{
    age = int.Parse(s);
}
catch( FormatException e)
{
    Console.WriteLine("잘못 입력 했습니다. 다시 입력해 주세요");
}

Console.WriteLine($"입력된 나이는 {age} 입니다");