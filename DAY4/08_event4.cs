using static System.Console;

class Button
{
    public delegate void Handler();

    // 아래 처럼하면 Click 에 대해서 : =, +=, -= 모두 사용가능
//  public Handler Click = null;

    // 아래 처럼하면 Click 에 대해서 : +=, -= 만 가능. = 안됨
    //                              최초 등록시도 += 만 가능

    // 결국 event 는 "delegate" 를 안전하게 사용하기 위한것
    public event Handler Click = null;

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

        
//        btn1.Click = Foo; // error
        btn1.Click += Foo; // error
        btn1.Click += Goo;

        btn1.Click += Hoo; 

        
        

        btn1.UserPressButton();
    }
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
    public static void Hoo() => WriteLine("Hoo");
}