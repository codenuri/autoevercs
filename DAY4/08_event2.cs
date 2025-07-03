using static System.Console;

class Button
{
    // #1. �Ʒ� �ڵ�� "Handler" ��� Ÿ���� �����!
    // => ������ �޼ҵ� ���(void())
    delegate void Handler();

    // #2. Handler Ÿ���� Click �̶�� �ʵ�
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
        Button btn2 = new Button();

        // ��ư�� ������, �� ��ư�� �������� ȣ��� �޼ҵ带 ����մϴ�.
        btn1.Click = Foo;
        btn2.Click = Goo;

        btn1.UserPressButton(); 
        btn2.UserPressButton();  		
    }
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
}