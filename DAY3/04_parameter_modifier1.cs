using static System.Console;

// �߿��մϴ�. - 79 page

// C����� call by value �� call by reference ����
//         

class MyMath
{
    public static void Inc1(int x)
    {
        ++x;    
    }
}

class Program
{
    public static void Main()
	{
		int n1 = 0;
//      int x = n1; // value type �̹Ƿ� ���纻 ����

        MyMath.Inc1(n1); // int x = n1 �� �ǹ��̹Ƿ�
                         // Inc1 ���� ������ ���纻 x �����Ѵ�.
                         // ++x �� ���纻�� ����ǰ�, ���� n1 �� ����ȵ�

		WriteLine($"{n1}"); 
    }
}