class Person
{
    private int age;
    
    // 아래 Age 는 ()가 없으므로 "필드" 처럼 보입니다.
    // 그런데, {} 가 있으므로 "메소드" 처럼 보입니다.
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10;
        int n = p1.Age;
    }
}
