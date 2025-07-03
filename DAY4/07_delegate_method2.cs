using static System.Console;

delegate void MyFunc(int arg);

// delegate_method1 : SMethod �� IMethod �� Test Ŭ���� ���
// �Ʒ� �ڵ�         : SMethod �� IMethod �� �ڽ�(Program)Ŭ���� ���

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // �ڽ��� static method ���
        MyFunc f1 = ?;
        MyFunc f2 = ?;

        // �ڽ��� instance method ���
        MyFunc f3 = ?;
        MyFunc f4 = ?;

    }

	public void InstanceMethod()
	{
	}
}
