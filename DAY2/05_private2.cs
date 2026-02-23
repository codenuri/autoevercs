using static System.Console;

// 객체지향 언어의 3대 특징 : 캡슐화, 상속, 다형성

// 캡슐화(encapsulation)
// => 상태를 나타내는 필드를 private 에 놓아서
// => 외부의 잘못된 사용으로 부터 객체의 상태가 불안전해 지는 것을 막는다
// => 객체의 상태는 잘 정의된 메소드를 통해서만 변경 가능하다
// => 안전하고, 사용하기 쉬운 타입 설계

// 일반적인 관례
// 필드는   private
// 메소드는 public 


// C++, C#, Java : private, public 모두 지원
// Python : 이 개념 없음


class Bike
{
    private int gear = 0;

    public void SetGear(int g)
    {
        // 인자 값의 유효성을 확인한후
        // 인자가 유효한 경우만 자신의 상태(필드)를 변경한다.
        // => 객체는 항상 안전한(유효한) 상태를 유지하게 된다.
        if ( g > 1 && g < 20 )
            gear = g; 
    }
}
class Program
{
    public static void Main()
    {
        Bike b = new Bike();

//      b.gear = -10; // error
        b.SetGear(-10); // ok. 하지만 잘못된 값을 전달했으므로 무시됨
        b.SetGear(5);   // ok. 상태 변경

        // 이제 사용자는 어떤 방법을 사용해도
        // gear 의 상태가 잘못된 값을 가지게 할수 없다.
        // => Bike 는 아주 안전하다
    }
}


