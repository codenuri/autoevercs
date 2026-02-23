class Person
{
    private int age;

    // Property 문법 : C++/Java 에는 없고, C# 에만 있는 고유 특징 
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
        Person p = new Person();
        p.age = 10; // error. 필드는 private 에 있음
        p.Age = 10; // ok.  set 부분 호출
        int n = p.Age;// ok. get 부분 호출
    }
}
