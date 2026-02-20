// 06_loop_example.cs

// 사용자가 "Q" 를 입력하면 종료, 그렇지 않으면 다시 입력 받아라

// 최소 한번은 입력 받는 루틴이 실행되어야 한다.
string s;

do
{
    Console.Write("input command => ");

    s = Console.ReadLine();
} while (s != "Q");
