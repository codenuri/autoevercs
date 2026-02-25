using static System.Console;

delegate void Handler();

class Button
{
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

        btn1.UserPressButton();  

    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}