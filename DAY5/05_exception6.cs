
int age = 0;

while(true)
{
    Console.Write("나이를 입력해 주세요 >> ");

    string s = Console.ReadLine();   // "aa" 입력해 보세요

    try
    {
        age = int.Parse(s);
    }
    catch( FormatException e)
    {
        Console.WriteLine("잘못 입력 했습니다. 다시 입력해 주세요");
        continue; // 루프의 시작으로 이동
    }
    break; // 예외가 없었다면 루프 탈출!
}

Console.WriteLine($"입력된 나이는 {age} 입니다");