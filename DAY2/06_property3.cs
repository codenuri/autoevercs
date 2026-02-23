class Person
{
    private int age;


    // get/set 중 한개만 만들어도 됩니다.
    public int Age
    {
//      get { return age; }
        set { if (value > 0) age = value; }
    }
}
class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Age = 10;     // ok
//      int n = p.Age;  // error

    }
}
