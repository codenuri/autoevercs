using static System.Console;

// 캡슐화(encapsulation)
// => 객체의 상태를 나타내는 필드(데이타)는 private 에 놓아서
// => 외부의 잘못된 사용으로 객체의 상태가 불안해지는 것을 막는다.

// => 객체의 상태는 잘 정의된 메소드를 통해서만 상태가 변경될수 있다.
// => 객체가 항상 유효한 상태임을 보장한다.


// 거의 모든 객체지향 언어는 "private, public" 키워드가 있습니다.

// 그런데, Python 에 없습니다
// => 추가 하자고 요청이 많은데.. 아직은....






// 객체지향언어의 3대 특징 : 캡슐화, 상속, 다형성

class Bike
{
    private int gear = 0;

    public void SetGear(int value)
    {
        // 인자의 유효성 여부를 확인해서
        // 인자가 유효할때만 객체의 상태를 변경한다.
        // "객체의 상태는 항상 유효한 값을 가지게 된다."

        if( value > 0 && value < 20 )
            gear = value;
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();
                
//        b.gear = -10;  // error. private 필드는 접근 안됨.
        b.SetGear(-10);  // ok
                         // 에러는 아니지만,
                         // 인자값이 유효하지 않으므로
                         // 무시 된다.!
    }
}


