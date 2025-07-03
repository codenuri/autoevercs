using static System.Console;

class Animal
{
    // non-virtual : �޼ҵ� �տ� virtual �� ���� ��
    // => static binding �ش޶�� �ǹ�
    // => �����Ͻ� ȣ�� ����
    public void Cry1() { WriteLine("Animal Cry1");}


    // virtual method : �޼ҵ� �տ� virtual �� �ִ°�
    // => dynamic binding �ش޶�� ��
    // => ����� �޸� ������ ȣ�� ����
    public virtual void Cry2() { WriteLine("Animal Cry2"); }
}

class Dog : Animal
{
    // non-virtual �� override �Ҷ��� "new"
    public new void Cry1() { WriteLine("Dog Cry1");}

    // virtual �� "override" Ű���� ���
    public override void Cry2() { WriteLine("Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
		Animal ad = new Dog();

		ad.Cry1();  // ?
        ad.Cry2();  // ?
    }
}

