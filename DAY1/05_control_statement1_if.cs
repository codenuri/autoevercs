using static System.Console;


// 프로그램은 "약속된 entry point" 부터 순차적으로 실행됩니다
// 1. 실행흐름을 변경하려면 조건문
// 2. 실행흐름을 반복하려면 반복문 사용

//          조건문 2개                  반복문 2~4개
// C      : if, switch                 while, do-while, for
// Python : if, match(switch와유사)     while,   -,      -,   for(C와다름)   
// C#     : if, switch                  while, do-while, for, foreach(파이썬의for)


// 핵심 : if 문
// => 대부분 언어가 개념은 완전히 동일
// => 단지, 표기법에서만 차이가 있음.

//              조건식                 {}
// Python       () 생략가능             {} 대신 들여쓰기로
// C#           () 필수                 {} 안의 문장이 한문장이면 생략가능. 단 붙이는 것을 권장
// C            () 필수                 {} 안의 문장이 한문장이면 생략가능
int score = 75;

if (score > 70 )
    WriteLine("Pass");

else if( score < 40) 
{
    WriteLine("Fail");
}
else
    WriteLine("Reexam");
