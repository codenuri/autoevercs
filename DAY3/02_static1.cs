using static System.Console;

// static 개념
// => C++/Java/C#/Python 등 모든 객체지향 언어가 지원하는 공통의 개념
// => 프로그램을 배우려면 반드시 알아야 합니다.



class Car 
{
    private int speed = 0;  

    // 생성자
    // => 클래스 이름과 동일한 약속된 메소드
    // => 객체를 생성하면 자동으로 호출
    // => 목적 : 필드를 초기화
    public Car(int s)
    {
        speed = s;
    }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

    }
}