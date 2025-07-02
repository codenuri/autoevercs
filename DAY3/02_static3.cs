using static System.Console;

// 방법 #2. static field 사용 - 성공

// 이소스의 핵심 : static field 특징
// 1. 객체가 없어도 메모리에 존재
// 2. 객체 생성시 객체 메모리 공간에는 포함 안됨
// 3. 오직 한개만 존재하고 모든 객체가 공유
// => 모든 자동차 객체가 공통으로 사용할 데이타 만들때 사용


class Car
{
    private int speed = 0;

//  public int cnt = 0;     // instance field
                            // => 객체당 한개씩 생성

    public static int cnt = 0;  // static field
                                // => 오직 한개만 생성
                                // => 객체를 여러개 생성해도 cnt 는 메모리에
                                //    한개이고
                                // => 모든 객체가 공유
                                // => 객체를 만들지 않아도 메모리에 존재
                                // => C 언어의 전역변수공간에 생성됨

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

        // static field 는 객체이름이 아닌 class 이름으로 접근

        WriteLine($"{Car.cnt}"); 
    }
}


