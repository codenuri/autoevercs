using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // #1. int.Parse() : ���ڿ��� ������ ����
        int n1 = int.Parse("10");    // ok. ����
        int n2 = int.Parse("Hello"); // ����. ���� �߻�


        // int.Parse() : ���н� ���� �߻�, ó������ ������ ����������
        // int.TryParse() : ����/���� ���ΰ� ��ȯ��
        //                  ������ �����  2��° ���ڿ� ��� �ݴϴ�.

//      int ret;
//      bool b = int.TryParse("hello", out ret  );


        // �� 2���� ���ٷ� �غ�����
        bool b = int.TryParse("hello", out int ret);

        if ( b == false )
        {
            // ���� ó��
        }
    }
}