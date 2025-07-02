



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
        w.AddChild(tb); // ??
    }
}