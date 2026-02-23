class Person
{
    private int age;

    // C# 에서는 expression bodied 를 많이 사용
    public int Age
    {
        get => age;
        set => age = value;  // if 등을 사용하려면 {} 로 구현
    }
}
class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Age = 10;     
        int n = p.Age;  r

    }
}
