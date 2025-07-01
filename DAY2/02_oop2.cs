using static System.Console;

// 객체지향 프로그래밍의 핵심
// => 프로그램에서 필요한 타입을 먼저 설계해라!!!
// => 대부분의 언어는 타입을 만드는 class 문법 제공

class Rect
{
    int x1 = 0;
    int y1 = 0;
    int x2 = 0;
    int y2 = 0;
}

// 이제 사각형이 필요하면 사각형 타입 변수를 만듭니다.
// => 사용자 정의  타입 변수를 만들때는 "new" 사용
Rect rc = new Rect();