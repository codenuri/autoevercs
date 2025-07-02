using static System.Console;

// 프로그램에서 자동차(객체)를 "몇개" 만들었는지 알고 싶다.
// => 모든 객체는 만들때 생성자가 호출되므로
// => 생성자에서 "++" 하면 되지 않을까 ?

// 방법 #1. cnt 변수를 아래 같은 field 로 선언
// => field 는 객체당 한개이다.
// => c1, c2즉, 모든 자동차가 따로 사용한다.
// => 객체 갯수 파악 실패!!


class Car
{
    private int speed = 0;
    public int cnt = 0;

    public Car(int s)
    {
        speed = s;
        ++cnt;
    }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car(50);
        Car c2 = new Car(80);

        WriteLine($"{c1.cnt}"); // 의도는 2가 나오길 바라는데...
                                // 결과는 1
    }
}