// 왜 ??? Dog 객체를 Animal 참조에 담나요 ??
// 그냥 Dog 참조에 담으면 안되나요 ?
// GUI 라이브러리를 설계해 봅시다.
class Window
{
    List<Button> child_list = new List<Button>();

    public void AddChild(Button btn)
    {
        child_list.Add(btn); // 자식컨트롤 보관
    }
}

class Button 
{ 
}
class TextBox
{
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