
using static System.Console;
// ToString() �޼ҵ�� object Ŭ������ �����մϴ�.
/*
class object
{
	public virtual string ToString()
	{
		// �⺻ ������ ���� ��ü�� Ÿ���̸��� ���ڿ��� ��ȯ
	}
}
*/

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);

    public override string ToString()
    {
		string s = $"x = {x}, y = {y}";

		return s;
    }
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1, 2);

		string s = p.ToString();

		WriteLine(s);
    }
}
