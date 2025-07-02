// 왜 ??? Dog 객체를 Animal 참조에 담나요 ??
// 그냥 Dog 참조에 담으면 안되나요 ?
// GUI 라이브러리를 설계해 봅시다.
class Window
{
    //  List<Button> child_list = new List<Button>(); // 버튼 밖에 보관할수 없다

    //  List<object> child_list = new List<object>(); // 모든 객체를 보관할수 있다.
                                                    // int 도 보관된다. ???
                                                    // 자식윈도우는 UI 만 허용해야 한다.

    List<UIElement> child_list = new List<UIElement>();

    public void AddChild(UIElement element)
    {
        child_list.Add(element); // 자식컨트롤 보관
    }
}

// 모든 컨트롤은 묶어서 관리 가능해야 합니다.
// => 하나의 저장소에 모든 종류 컨트롤을 보관
// => 기반 클래스를 설계 합니다.
// => "상속" 은 요소를 물려 받기도 하지만,
//    여러 타입을 묶을때 도 사용합니다.

class UIElement
{
    // 모든 UI의 공통의 특징을 설계
    private int backgroundColor;
    private int foregroundColor;
}
// 이제 모든 컨트롤은 UIElement 에서 상속 받아야 합니다.
class Button : UIElement
{ 
}
class TextBox : UIElement
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