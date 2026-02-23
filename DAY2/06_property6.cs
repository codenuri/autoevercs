class Person
{
    /*
    // #1. 필드를 만들고
    private int age;

    // #2. age 에 대한 Property 작성
    // => 필드이름의 1글자를 대문자로 하는 것이 관례
    public int Age
    {
        get => age;
        set => age = value;
    }
    */
    // 위 property 는 어떤 추가적인 logic 없이 값을 그대로 필드에 대입합니다.
    // 이 경우 아래 한줄만 작성하면 위와 완전히 동일
    // auto-implemented property 개념
    public int Age { get; set; } = 0;
}

class Program
{
    public static void Main()
    {



    }
}
