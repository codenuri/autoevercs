using static System.Console;

// java �ƽô� ���� �� ������ �����Դϴ�.

// Value Type vs Reference Type 

// C# �� ��� Ÿ���� "class" �Ǵ� "struct" �������� ��������ϴ�.

// class  �� ����� : Reference Type
// struct �� ����� : Value Type

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// #1. �Ʒ� 2���� ������ ������� ��ü�� �����մϴ�.
		// => �׷���, �޸� ������ ������ �ٸ��ϴ�.
		// => ���� "36page" �׸��� �߿�
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);


		string s = "AA";
	}
}

// stack
// => ũ�Ⱑ �۽��ϴ�.(���� 1MB)
// => �Ҵ�/���� �ӵ��� ���� �����ϴ�.
// => ���ʴ�� ����ϰ�, �������� �ı� �˴ϴ�.
// => ũ�Ⱑ �۰�, ���� ����� �Ǵ� ��ü(����)�� �̰��� ���




// ��
// => ũ�Ⱑ Ů�ϴ�.(�����ϴ� �ڵ�����, ��κ� 1G �̻�)
// => �Ҵ�/���� �ӵ��� stack ���� �����ϴ�.
// => �Ҵ�/������ �����ӽ��ϴ�.
// => ũ�Ⱑ ũ��, �ѹ� ������ �������� ����ϰ� �Ǵ� ��ü

// C/C++
// => Ÿ���� �����ڰ� �ƴ� ����ڰ� �޸� ��ġ ����
// int n = 0;           // ���ÿ� ����� �޶�.
// int* p = new int(0); // ���� ����� �޶�.

// �׷���, � Ÿ��(int, Rect ��)�� ũ���
// => Ÿ�� ����� ���� �����ڰ� ��Ȯ�� �˰� �ִ�.


// C#/Java/Swift
// => Ÿ���� �����ڰ� ����(��ü)�� �޸� ��ġ ����
// struct �� ���� Ÿ�� : ��� ��ü�� ���ÿ� ����. value type
// class  �� ���� Ÿ�� : ��� ��ü ��ü�� �� ����. stack  ����
//						����ü�� ����Ű�� ����(������, ����) ����
//						reference type