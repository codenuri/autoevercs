using static System.Console;

// ���� �߻�Ŭ������ ����ϰ�, ���� �������̽��� ����ϳ��� ?

// ���� ������ Shape
// => ��� ������ color ���� ��� �ʿ� �մϴ�.
// => �߻� Ŭ������ �����ϴ�.

// �������̽�
// => �Լ� �̸��� ����ϰ� ������
// => interface1 ~ 2 ����



class Program 
{
	public static void Main()
	{
		int n1 = 10;
		int n2 = 20;

		string s1 = "AAA";
		string s2 = "BBB";

		// �� ������ ũ�⸦ ���ϴ� ���. 

		// #1. �� ������(<, >,...) ���
		// => ����, �Ǽ� ���� ���� Ÿ�Ը� ����
		bool b1 = n1 < n2; // ok
		bool b2 = s1 < s2; // error

		// #2. CompareTo �޼ҵ� ���
		// => C# ���� �� ������ ��� Ÿ�Կ��� CompareTo �޼ҵ� �ֽ��ϴ�.
		int ret1 = n1.CompareTo(n2); // n1 > n2 ��� ��� ��ȯ (1 )
									 // n1 < n2 ��� ���� ��ȯ (-1)
									 // n1 == n2 ��� 0
		int ret2 = s1.CompareTo(s2);

    }




    public static void M1(IComparable ic)
	{
	}

}
