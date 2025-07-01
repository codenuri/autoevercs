using static System.Console;

// 58 page 위 그림

// int  : 정수 한개 값 보관
// int? : 정수 한개 값 보관 + bool 값 보관

// int? 는 int 를 포함한다.

// 58 page 그림 참고해서 아래 코드 에러 여부 생각해 보세요
int n = 0;
int? n1 = n; // ok

// int <= int?
int n2 = n1; // error

int n3 = (int)n1; // ok.
                  // 단, n1 == null (n1.hasValue 가 false)라면 에러(예외발생)


// 안전하게 하려면
// #1. 조사후 캐스팅
//if ( n1 != null )
if ( n1.hasValue )
{
    int n4 = (int)n1;
}

// #2. Nullable 의 GetValueOrDefault() 메소드 사용
int n5 = n1.GetValueOrDefault(9); // n1 != null 이면 n1 이 가진값
                                  // n1 == null 이면 9
int n6 = n1.GetValueOrDefault();  // n1 == null 이면 int 의 디폴트값(0)