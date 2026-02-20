using static System.Console;


// 프로그램은 "약속된 entry point" 부터 순차적으로 실행됩니다
// 1. 실행흐름을 변경하려면 조건문
// 2. 실행흐름을 반복하려면 반복문 사용

//          조건문 2개                  반복문 2~4개
// C      : if, switch                 while, do-while, for
// Python : if, match(switch와유사)     while,   -,      -,   for(C와다름)   
// C#     : if, switch                  while, do-while, for, foreach(파이썬의for)


// 핵심 : if 문

int score = 75;

if (score > 70 )
{
    WriteLine("Pass");
}
else if( score < 40)
{
    WriteLine("Fail");
}
else
    WriteLine("Reexam");
