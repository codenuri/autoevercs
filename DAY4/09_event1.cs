using static System.Console;

class Button
{
	public void UserPressButton()
	{
		// 버튼 누를때 해야할 일을 여기서 직접 한다면

		// 모든 버튼(btn1, btn2) 가 동일한 일을 하게 됩니다.
	}
}

class Program
{
	public static void Main()
	{
		Button btn1 = new Button(); // 이순간 GUI 버튼이 만들어 지고
		Button btn2 = new Button();
	
		btn1.UserPressButton(); // 사용자가 버튼을 누르면
		btn2.UserPressButton(); // 이 메소드가 호출된다고 가정. 		
	}
}