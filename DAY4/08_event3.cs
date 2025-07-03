using static System.Console;

class Button
{
    public delegate void Handler();

    public Handler Click = null;

    public void UserPressButton()
    {
        if (Click != null)
        {
            Click();
        }
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button();

        btn1.Click = Foo;
        btn1.Click += Goo;

        btn1.Click = Hoo; // += 하려고 했는데, 실수로 =을 했다
                        // 이전에 등록된 메소드가 제거된다.!
                        // 버그 !!    
                        // 해결책은 event4.cs

        btn1.UserPressButton();
    }
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
    public static void Hoo() => WriteLine("Hoo");
}