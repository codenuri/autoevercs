



class UIElement
{
    private int backgroundColor;
    private int foregroundColor;
}
class Button : UIElement
{
}
class TextBox : UIElement
{
}

class Window
{
    List<UIElement> child_list = new List<UIElement>();

    public void AddChild(UIElement element)
    {
        child_list.Add(element);
    }

    // 아래 메소드 반환 타입이 "UIElement" 일수 밖에 없는 이유를 
    // 정확히 알아야 합니다.
    public UIElement GetChild(int idx)
    {
        return child_list[idx];
    }
}



class Program
{
    public static void Main()
    {
        Window w = new Window();

        Button b1 = new Button();
        Button b2 = new Button();
        w.AddChild(b1);
        w.AddChild(b2);

        TextBox tb = new TextBox();
        w.AddChild(tb); //

        // 2번째 부착된 자식을 꺼내고 싶다
        // => 분명이 2번째 부착한 자식은 Button 이지만
        // => GetChild() 반환 타입이 UIElement 일수 밖에 없었습니다.
        // => 그래서 반환 값을 UIElement 로 받을수 밖에 없습니다.
        UIElement child = w.GetChild(1);

        // 그런데, child 를 사용하면
        // => UIElement 기능을 사용할수 있지만 
        // => Button 고유의 기능을 사용할수 없습니다.
        // => 그래서 다시 Button 으로 캐스팅해야 합니다.

        if ( child is Button btn)
        {
            // btn.버튼고유메소드();
        }
    }
}