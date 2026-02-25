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

        // 버튼 누를때 호출될 함수 등록
        btn1.Click = Foo; 
        btn2.Click = Goo;

        btn1.UserPressButton();  // 등록된 함수 호출
        btn2.UserPressButton(); 	
    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}