using static System.Console;

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
    }
}


