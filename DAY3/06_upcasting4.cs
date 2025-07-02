



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

    public ? GetChild(int idx)
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
        Button child = w.GetChild(1);
    }
}