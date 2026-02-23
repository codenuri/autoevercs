// object 이야기

// C# 언어만의 특징(C++, Java 와 다른)
// => 거의 모든 타입은 자동으로 Object 라는 클래스로 부터 상속받는다
// 
class Car   // class Car : Object 의 의미
{
}
class Program
{
    public static void Main()
    {
        Car c = new Car();
        string s = c.ToString(); // 타입이름이 문자열로

        // 결론 : C#의 모든 변수에는 ToString()메소드가 있다

        int n = 10;
        n.ToString();

        // Object 클래스가 가진 모든 메소드는.
        // => C#의 거의 모든 변수가 가지고 있는 메소드
        // => 중요하므로, 각 메소드의 기능을 알아야 한다
    }
}