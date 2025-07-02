// C# 의 모든 타입은 자동으로 "object" 라는 클래스에 상속됩니다.

// class Car : object   // 아래 코드는 컴파일러에 의해서 이렇게 됩니다.
class Car    
{
}

class Program
{
    public static void Main()
    {
        Car c = new Car();

        c.ToString(); // object 로 부터 상속 된것


        // int, double, string 등의 모든 기본 타입도 object 에서 상속됨
        // => 그래서 object 가 제공하는 7개 메소드가 있습니다.
        int n = 0;
        n.ToString(); // object 에서 상속 받은것

        // C#의 모든 객체는 ToString() 메소드 있습니다.
    }
}