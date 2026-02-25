/*
class Object
{
    // 2개의 static method
    public static bool Equals(object? objA, object? objB) { ... };
    public static bool ReferenceEquals(object? objA, object? objB) { ...};

    // 2개의 non-virtual method
    public Type GetType() { ... };
    protected object MemberwiseClone() { ... };

    
    // 3개의 virtual method
    public virtual bool Equals(object? obj) { ... };
    public virtual int GetHashCode() { ... };
    public virtual string? ToString() { ... };
}
*/

// 1. C# 의 거의 모든 타입은 자동으로 "Object" 로 부터 상속 받게 됩니다.
// 2. Object 클래스 에는 7개의 메소드가 있습니다.
// => 이 7개의 메소드는 C# 의 모든 종류의 변수와값 에서 사용가능
// => Window w = new Window() 에서 w 에도 7개의 메소드 있음.  
class Car     // class Car : Object
{
    
}

class Program
{
    public static void Main()
    {
        Car c = new Car();
        var s = c.ToString();  

       
    }

}
