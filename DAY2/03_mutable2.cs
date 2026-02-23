// 42 page 그림
string s1 = "AB";
string s2 = s1; // 메모리 그림 생각하세요

s2 = "XY"; // new string("XY") 의 의미
           // 이순간 메모리 그림 생각

Console.WriteLine($"{s1} {s2}");

class CPoint
{
    public int x;
    public int y;
    public CPoint(int a, int b) { x = a; y = b; }
}

CPoint pt = new CPoint(0, 0);
pt.x = 10; // pt 가 가리키는 힙객체의 속성(필드) 변경한것

pt = new CPoint(1, 1);// 힙에 새로운 객체 만든것
s2 = "XY"; // 이 코드가 위 코드 의미.