// Collection 
using System.Drawing;

class Program
{
    public static void Main()
    {        
        List<int> s1 = new List<int>(); // 정확한 표기법

        List<int> s2 = new(); // 단축 표기법

        // C# 은 컴파일러의 의한 타입 추론이 아주 강력합니다.
        // s2 처럼만 표기해도 s1 과 완전히 동일


        Point pt1 = new Point(1, 1);
        Point pt2 = new (1, 1); // 위와 동일

    }
}

