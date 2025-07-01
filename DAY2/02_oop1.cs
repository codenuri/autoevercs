using static System.Console;

// 객체지향 프로그래밍의 기본 개념 => 교재 없는 내용
// => 아래 코드는 "사각형"을 표현하기 위해 int 타입변수 4개 사용합니다.
// => 그래서 코드가 복잡해 보입니다.



// 사각형의 면적을 구하는 함수 
int GetRectArea(int x1, int y1, int x2, int y2)
{
    return (x2 - x1) * (y2 - y1);
}

int area = GetRectArea(1, 1, 10, 10);
