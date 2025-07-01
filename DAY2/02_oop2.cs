using static System.Console;

// 객체지향 프로그래밍의 핵심
// => 프로그램에서 필요한 타입을 먼저 설계해라!!!
// => 대부분의 언어는 타입을 만드는 class 문법 제공

class Rect
{
    // 사각형의 정보를 보관할 데이타 - field 라고 부릅니다.
    int x1 = 0;
    int y1 = 0;
    int x2 = 0;
    int y2 = 0;

    // 사각형 관련 다양한 기능을 제공하는 함수 - method 라고 부릅니다.
    public int GetArea()
    {
        return (x2 - x1) * (y2 - y1);
    }
}

// 이제 사각형이 필요하면 사각형 타입 변수를 만듭니다.
// => 사용자 정의  타입 변수를 만들때는 "new" 사용
Rect rc = new Rect();
int ret = rc.GetArea();