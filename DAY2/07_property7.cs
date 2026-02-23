class Person1
{
    // 자동 구현 property : 값의 유효성 확인 없음
//  public int Age { get; set; } = 0;

    // 미래에 위 코드가 유효성 확인을 위해 아래 처럼 변경
    public int age = 0;

    public int Age
    {
        get => age;
        set {  if (value > 0) age = value; }    
    }
    // 핵심
    // Person1 의 구현이 변경되었지만
    // => 사용자 코드는 변경될 필요 없다
}

class Person2
{
    // public 필드 : 값의 유효성 확인 없음
    public int age = 0;

    // age 부분을 property 로 만들게 되면
    // 외부 사용자 코드도 모두 변경되어야 한다.

    // 즉, 유효성 검사가 당장 없더라도..
    // => public 필드로 하지 말고
    // => auto property 로 만드는 것이 좋다
}

class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
        Person2 p2 = new Person2();

        p1.Age = -10;
        p2.age = -10;
    }
}
