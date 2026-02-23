class Person
{
    private int age;

    // Property 문법 : C++/Java 에는 없고, C# 에만 있는 고유 특징 
    // => 필드, 메소드가 아닌 새로운 형태의 문법
    // => 관례 : 필드는 소문자, 메소드와 Property는 1글자 대문자 
    public int Age
    {
        get { return age; }
        set { if ( value > 0) age = value; }
    }
}
class Program
{
    public static void Main()
    {
        Person p = new Person();
//      p.age = 10; // error. 필드는 private 에 있음

        p.Age = 10;    // ok. set 부분 호출, 10은 약속된 value 에 전달
        int n = p.Age; // ok. get 부분 호출

        // 만들때는 "메소드" 와 유사하지만
        // 사용자시는 "필드" 처럼 접근

        // 결국 : Getter/Setter 를 편리하게 만들고, 사용하는 문법
    }
}
