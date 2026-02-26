using static System.Console;

class MyUtil
{
	// Swap 만드세요
	public static void Swap(ref int a, ref int b)
	{
		int t = a;
		a = b;
		b = t;
	}
}
class Program
{
    public static void Main()
	{
		int x = 1;
		int y = 2;

        MyUtil.Swap( ref x, ref y); 

		// 아래 결과가 2, 1이 나오도록 Swap 을 만들어 보세요
		WriteLine($"{x}, {y}");	// 2, 1
				
	}
}