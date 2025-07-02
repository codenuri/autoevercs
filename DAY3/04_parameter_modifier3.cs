using static System.Console;

class Example
{
    public static void no_modifier_parameter(int x)
    {
        // x �� ���纻 �����Ѱ�
        // R/W ��� ����.
        // �Ʒ� �ڵ尡 �־ �ǰ� ��� �ȴ�.
//        int n = x; // A  Read
//        x = 0;     // B  Write

    }

    public static void out_parameter(out int x)
    {
        // x�� ��� ���� ����, �ʱⰪ�� �������� �ֽ��ϴ�.
//      int n = x; // ����, �ʱⰪ ������ ����
//      x = 0;     // ok. 
                   // �ٽ� : ������ ��� ����!!!
                   //        ����ֱ�� �ߴµ�, ������� ������
                   //        �̸޼ҵ� ȣ���� �ش� ������ ����Ҽ� ���� �ǹǷ�
    }

    public static void ref_parameter(ref int x)
    {
        // x �� R/W ���� ���� ����, �ʱ�ȭ �Ǿ� ����.
        //int n = x; // ok
        //x = 0;     // ok
        //=> �� 2�پ�� ���� �ƴ�. 
    }
}

class Program
{
	public static void Main()
	{
		int n1;		
		int n2 = 0; 

        Example.out_parameter(out n1); 
        Example.out_parameter(out n2); 

        Example.ref_parameter(ref n1); 
        Example.ref_parameter(ref n2); 

        Example.out_parameter(out int n3); 
	}
}