using static System.Console;

delegate void Handler();

class Button
{
    //  public Handler Click = null;


    // event 가 없으면 : =, +=, -= 모두 사용가능
    // event 가 있으면 : +=, -= 만 가능, = 안됨

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

       
//      btn1.Click = Foo;
        btn1.Click += Goo;
//      btn1.Click = Goo; // += 하려고 했는데, 실수 했다  
                          // 이전에 등록한 함수가 모두 제거된다.

        btn1.UserPressButton();  

    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}