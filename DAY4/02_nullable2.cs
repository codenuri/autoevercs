using static System.Console;

// 58 page

// int  : 정수 한개 보관
// int? : 정수 한개 + bool 보관(값 있음/없음)

// 위 주석을 참고해서 아래 변환 관계를 생각해 보세요

// #1. int?   = int 
//     5바이트 = 4바이트
int n = 0;
int? n1 = n; // ok. (hasValue = true, value = 10)



// #2. int    = int?
//     4바이트 = 5바이트(value + bool)
// int n2 = n1; // error

int n2 = (int)n1; // ok.
                  // 1. n1 != null 이면 아무 문제 없음
                  // 2. n1 이 null 이었다면 예외 발생

// #3. int? 에 의 값을 안전하게 int 로 옮기기
if ( n1 != null )
{
    int n3 = (int)n1; // 조사했으므로 항상 안전
}

int n4 = n1.GetValueOrDefault(9);
int n5 = n1.GetValueOrDefault();
