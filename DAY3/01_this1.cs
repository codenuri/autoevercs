// #1. 필드는 객체당 한개씩 메모리에 생성된다.
// => Point 객체를 2개 만들때, x, y 도 각각 2개씩 존재하게 된다.

// #2. 객체를 여러개 생성해도 메소드는 코드메모리에 한개만 있다.
// => 모든 객체는 한개만 있는 "함수(메소드)" 는 공유하는 것

// #3. 메소드는 컴파일 되면 인자로 객체의 참조를 받는 this 추가됩니다.

// 파이썬 : 클래스 만들때 개발자가 메소드에 직접 self 받아야 합니다
/*
class Point:
    def Set(self, a, b):
        self.x = a
        self.y = b  

p = Point()
p.Set(1,2)  // Set(p, 1, 2) 가 되기때문에 위 Set 은 1번째 인자로 self 필요
*/
// C++/Java/C#
// => 개발자는 Set(int a, int b) 로만 만들면 컴파일러가 객체를 받는 인자를 추가
// => 컴파일러가 Set(Point this, int a, int b) 로 변경


class Point
{
    private int x = 0;
    private int y = 0;
    
    public void Set(int a, int b) // void Set(Point this, int a, int b)
    {                             // {
        x = a;                    //     this.x = a;
        y = b;                    //     this.y = b;

        // 핵심 : 메소드 안에서 this 의 의미는
        // => 현재 메소드를 사용할때 호출한 객체를 의미 합니다.
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        p1.Set(1, 2); // 컴파일 되면 인자가 3개로 변경됩니다.
                      // Set(p1, 1, 2)

        p2.Set(1, 2); // Set(p2, 1, 2)
    }
}
