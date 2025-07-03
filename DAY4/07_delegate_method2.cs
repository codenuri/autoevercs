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
        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;


        // �ڽ��� instance method ���
        // �ٽ� : ���� Main �޼ҵ�� static �̹Ƿ� Program ��ü(this)�� ����
        // ��ü�� ������ IMethod ��밡��
        Program pg = new Program();

        MyFunc f3 = pg.IMethod;
//      MyFunc f4 = IMethod; // �ɱ�� ? error.
                             // Main �� static �̹Ƿ� this �����ϴ�

        pg.InstanceMethod();
    }

	public void InstanceMethod()
	{
        // ���� �޼ҵ尡 ȣ��Ǿ��ٴ� ���� ��ü �� �ִٴ� ��
        MuFunc f1 = this.IMethod; //ok
        MuFunc f2 = IMethod;      // ok
    }
}
