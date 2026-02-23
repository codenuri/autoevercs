using static System.Console;

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


