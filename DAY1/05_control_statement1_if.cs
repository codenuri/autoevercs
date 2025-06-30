using static System.Console;

// 제어문(67page ~ )

// 모든 프로그램은 "약속된 entry point" 에서 부터
// 순차적으로 실행됩니다.
// 1. 실행흐름을 변경하려면 조건문(conditional statement) 사용
// 2. 실행흐름을 반복하려면 반복문(iterative   statement) 사용

// 조건문
// C 언어  : if, switch
// C# 언어 : if, switch
// Python : if, match(3.12 버전에서 추가, switch 와 유사) 

// 반복문
// C    : while, do-while, for
// C#   : while, do-while, for, foreach
// Python : while, for(C# foreach와 유사)


// 핵심 : if 문

int score = 75;

// 핵심 #1. 파이썬은 () 생략가능하지만, C# 은 필수!
//      2. C 언어는 실행문장이 1줄이면 {} 생략가능, C#은 필수

if (score > 70)
{
    WriteLine("Pass");
}
else if (score < 40)
{
    WriteLine("Fail");
}
else
{
    WriteLine("Reexam");
}

// 주의 () 안에는 반드시 bool 타입만 가능합니다.
if ( score ) // C 언어 ok. score가 0이면 false, 0 아니면 true
{            // C# error. (score != 0) 으로 해야 한다.
}

