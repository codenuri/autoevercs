using static System.Console;

// 객체지향 프로그래밍의 기본 개념. 


// 사각형의 면적을 구하는 함수 
int GetRectArea(int x1, int y1, int x2, int y2)
{
    return (x2 - x1) * (y2 - y1);
}

int area = GetRectArea(1, 1, 10, 10);
