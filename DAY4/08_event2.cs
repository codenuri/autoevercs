using static System.Console;

class Button
{
    // #1. 아래 코드는 "Handler" 라는 타입을 만든것!
    // => 저장할 메소드 모양(void())
    // => delegate 를 class 안에 만들때는 public 으로 해야
    //    해당 Delegate 변수를 다시 public 으로 할수 있습니다.
    public delegate void Handler();

    // #2. Handler 타입의 Click 이라는 필드
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

        // 버튼을 만든후, 각 버튼을 눌렀을때 호출될 메소드를 등록합니다.
        btn1.Click = Foo;
        btn2.Click = Goo;

        btn1.UserPressButton(); 
        btn2.UserPressButton();  		
    }
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
}