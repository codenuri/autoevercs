class Program
{
    // 메소드 인자가 object 타입이면
    // "모든 타입의 변수를 받을수 있다."
    public static void Foo(object obj)
    {
        // obj 가 어떤 타입인지 알고 싶다

        // #1. is 연산자 : obj 가 int 타입인지 조사
        if ( obj is int )
        {
        }

        // #2. GetType() 메소드 사용
        // => GetType()은 Object 에서 파생된 메소드 이므로
        //    모든 변수가 가지고 있다
        Type t = obj.GetType();

        Console.WriteLine(t.Name);

    }
    public static void Main()
    {
        int n = 10;
        double d = 3.14;

        Foo(n);
        Foo(d);
        Foo("abc");
    }

}
