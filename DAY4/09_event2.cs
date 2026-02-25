using static System.Console;

// delegate 가 사용되는 용도
// => 버튼등의 GUI 에 함수를 등록했다가
// => 해당 이벤트 발생시 등록된 함수 호출

delegate void Handler();

class Button
{
    // Handler : delegate 이므로, 함수 정보를 보관하는 타입
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

        // 버튼 누를때 호출될 함수 등록
        btn1.Click = Foo; 
        btn2.Click = Goo;

        btn1.UserPressButton();  // 등록된 함수 호출
        btn2.UserPressButton(); 	
    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}