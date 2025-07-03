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
        btn1.Click += Hoo;


        btn1.UserPressButton();
    }
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
    public static void Hoo() => WriteLine("Hoo");
}