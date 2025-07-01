using static System.Console;

// C#의 모든 타입은 아래 2개중 한개 입니다.(39 page 표 )
// 1. Value Type        : struct, enum
// 2. Reference Type    : class, interface,  delegate

// 아래 코드를 보고
// 1. 메모리 그림을 그릴수 있어야 하고
// 2. 출력 결과를 예측할수 있어야 합니다.


// #1. int : value type, struct 로 만듬
int n1 = 10;
int n2 = n1; // 이순간 n2, n1 은 다른 객체(변수)

n1 = 20;

WriteLine($"{n1} {n2}"); // 20, 10


// #2. 배열 : reference type
// => 40 page 중간 그림.
// => 참고 : swift 는 배열이 value type 입니다.

int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;

WriteLine($"{x1[0]} {x2[0]}");	// 20, 1 






// #3. string 
string s1 = "AB";
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");  // ?, ? 