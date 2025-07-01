using static System.Console;

// C# 은 객체지향 언어
// => 필요한 타입을 만들자는 것

// 지금 부터 class(struct) 로 타입을 만들때 필요한 문법 정리
// => 자전거 관리 프로그램을 만들려고 한다.
// => Bike 타입을 만들자


// 접근 지정자
class Bike
{
    int gear = 0;
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();
    }
}


