using System.Drawing;
using static System.Console;
// 용어 정리

class Program
{
    public static void Main()
    {
        int n = 10;

        n = 20; // 이순간 n 의 값이 10에서 20으로 변경됩니다.
                // 그래서, n 을 "변수(변하는 수)" 라고 합니다.


        Rectangle rc = new Rectangle(1, 1, 10, 10);

        // rc 는 변하는 수가 아닌
        // "사각형 한개"를 나타내고 있습니다.
        // => 변수가 아닌 "객체" 라는 용어를 사용합니다.

        // 객체(object) : "세상에 존재하는 모든 사물"
        //                위 rc 는 메모리에 존재하는 요소

        // int n 에서 "n" 도 결국 메모리에 존재합니다.
        // => 그래서, n 도 변수가 아닌 "객체"라고 불러도 됩니다.

        // 그런데, C++/Java/C# 에서의 관례는
        // int, double 같은 primitive 타입이 메모리에 존재 : 변수
        // Rect, Window 같이 class(struct)로 만든 타입이 메모리에 존재 : 객체

    }
}
