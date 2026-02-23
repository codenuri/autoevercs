using static System.Console;

// 자전거를 관리하는 프로그램을 만들고 싶다
// => 자전거(Bike) 타입을 먼저 설계한다
// 접근지정자 : public, private
// public  : 어디에서도 접근 가능
// private : 자신의 메소드에서만 접근 가능

class Bike
{
//  public int gear = 0;
    private int gear = 0;
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

//      b.gear = -10; // 사용자가 실수로 기어를 음수로 설정
                      // error. private 이므로 Main 에서는 접근 안됨

    }
}


