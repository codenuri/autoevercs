using System.Drawing;
using static System.Console;

// 언제 추상클래스를 사용하고, 언제 인터페이스를 사용하나요 ?

// 도형 편집기 Shape
// => 모든 도형은 color 같은 멤버 필요 합니다.
// => 추상 클래스가 좋습니다.

// 인터페이스
// => 함수 이름만 약속하고 싶을때
// => interface1 ~ 2 예제



// C# 라이브러리 특징
// => 각 타입에서 공통으로 사용되는 메소드는 이름이 동일함을 보장하기위해
// => 메소드 이름을 인터페이스로 설계했습니다.
/*
interface IComparable
{
    int CompareTo(object obj);
}

// C# 라이브러리 설계 규칙 : 크기 비교가 가능하다면 IComparable 인터페이스를
//                         구현해라(CompareTo 구현 제공하라는 것)

// 그리고 int 타입 만들때 아래 처럼..
class Int32 : IComparable
{
    // CompareTo() 구현 제공
}

class String : IComparable
{
    // CompareTo() 구현 제공
}
*/

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        string s1 = "AAA";
        string s2 = "BBB";

  
        int ret1 = n1.CompareTo(n2); 
        int ret2 = s1.CompareTo(s2);

        // 메소드이름이 인터페이스로 약속되었기 때문에
        // 해당 인터페이스를 구현한 것만 별도로 처리하는 메소드를
        // 만들수도 있습니다.
        M1(n1); // ok
        M1(s1); // ok

//      Point p = new Point(); // equals 에 있는 클래스 복사
//      M1(p);  // error. IComparable 을 구현하지 않았습니다.
    }


    public static void M1(IComparable ic)
    {
    }

}
