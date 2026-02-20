using static System.Console;

int cnt = 0;

// while : 조건을 조사후 실행
while (cnt < 10)
{
    WriteLine("hello");
    ++cnt;
}

// do-while : 한번 실행후 조건조사
cnt = 0;

do
{
    WriteLine("hello");
    ++cnt;
} while (cnt < 10); // 조건이 false 라도 한번은 실행됨

// 사용자가 "Q" 를 입력하면 종료, 그렇지 않으면 다시 입력 받아라