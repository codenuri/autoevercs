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

        // 버튼을 만든후, 각 버튼을 눌렀을때 호출될 메소드를 등록합니다.
        btn1.Click = Foo;
        btn1.Click = Goo;

        btn1.UserPressButton(); 
        btn2.UserPressButton();  		
    }
}