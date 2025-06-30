using static System.Console;

// 핵심 : do ~ while

// while    : 조건 먼저 조사
// do-while : 무조건 한번 실행후 조건 조사

int cnt = 20;

while (cnt < 10) // 조건 false. 아래 구문 실행안됨
{
    WriteLine($"{cnt}");

    ++cnt;
}


do
{
    WriteLine($"{cnt}");

    ++cnt;
} while (cnt < 10); // 조건 false 라도 위 문장 실행