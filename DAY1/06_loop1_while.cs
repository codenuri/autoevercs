using static System.Console;

// 핵심 : while loop - python 과 동일

int cnt = 0;

while ( cnt < 10 )
{
    WriteLine($"{cnt}");

    ++cnt;
}

// 무한루프
cnt = 0;

while ( true )
{
    WriteLine($"{cnt}");

    ++cnt;

    if (cnt == 10)
        break; // 루프 탈출에 사용하는 키워드.
}