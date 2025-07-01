// 읽기/쓰기 전용 property

class Person
{
    private int age = 0;

    public int Age
    {
        get { return age; }
//        set { age = value; }
    }
}
class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10; // error
        int n = p1.Age; // ok
    }
}
