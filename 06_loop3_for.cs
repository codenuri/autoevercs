using static System.Console;

// 핵심 : for 문

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// 배열의 모든 요소 열거

// #1. 전통적인 for 문(C언어 부터 있던) 사용

// 1. (A) 한번 실행
// 2. (B) 조사후
// => 참이면 (D) 실행후 3으로
// => 거짓이면 탈출
// 3. (C) 실행후 다시 2로 이동

//     (A)       (B)     (C)
for( int i = 0; i < 10;  i++ )
{
    WriteLine($"x[i]"); // (D)
}

// #2. Python 스타일

// for e in x    <= 파이썬
foreach( int e in x ) // x의 모든 요소를 차례대로 e에 담아달라.
{
    WriteLine($"{e}");
}