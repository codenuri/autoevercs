using static System.Console;

class MyUtil
{
	// Swap ���弼��
	public static void Swap(ref int a, ref int b )
	{
		int temp = a;
		a = b;
		b = temp;
	}
}

class Program
{
    public static void Main()
	{
		int x = 1;
		int y = 2;

        MyUtil.Swap( ref x, ref y ); 

		// �Ʒ� ����� 2, 1�� �������� Swap �� ����� ������
		WriteLine($"{x}, {y}");	// 2, 1
				
	}
}