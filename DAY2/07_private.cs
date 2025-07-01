using static System.Console;

// C# 은 객체지향 언어
// => 필요한 타입을 만들자는 것

// 지금 부터 class(struct) 로 타입을 만들때 필요한 문법 정리
// => 자전거 관리 프로그램을 만들려고 한다.
// => Bike 타입을 만들자


// 접근 지정자
// private : 자신의 메소드만 접근 가능
// public  : 어디서도 접근 가능
class Bike
{
    // field : 객체의 상태를 나타내는 데이타
   
    private int color = 0;
    public  int gear = 0;  
}
class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        b.color = 10; // error. private 은 외부(Bike 메소드 아닌곳) 접근 안됨
        b.gear = 10;  // ok.    public Bike 메소드가 아닌곳도 접근 가능
    }
}


