using static System.Console;

class Button
{
    public void UserPressButton()
    {

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
        btn1.Click = Goo;

        btn1.UserPressButton(); 
        btn2.UserPressButton();  		
    }
}