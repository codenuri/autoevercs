using static System.Console;

class Button
{
	public void UserPressButton()
	{
		WriteLine("버튼을 누를때 여기서 작업수행");

		// 위 처럼 만들면 모든 버튼은 동일한 작업을 하게 됩니다.

		// 제대로 하려면
		// 메소드를 등록했다가
		// 버튼이 눌렸을때 등록된 메소드를 호출해야 합니다.
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