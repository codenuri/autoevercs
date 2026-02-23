class Person
{
    private int age;

    public int Age
    {
        get => age;
        set => age = value; 
    }
}
class Program
{
    public static void Main()
    {

//     Person p = new Person(10); // 인자가 한개인 생성자에 
                                        // 10을 전달해서 초기화
                                        // 지금은 인자 한개 생성자 없으므로에러

        // 객체 생성시 property 초기화 가능. {} 사용
        Person p = new Person { Age = 10 };
//      Person p = new Person { Age = 10, Name = "AAA" };

        Console.WriteLine(p.Age);

    }
}
