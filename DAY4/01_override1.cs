using static System.Console;

// 104 page ~ 

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}

class Dog : Animal
{
    // method override : ��� Ŭ���� �޼ҵ带 �Ļ�Ŭ������ �ٽ� ����� ��
    // => new �� ��� ������ �ƴѵ�, ��� �Դϴ�
    // => "�Ǽ��� �ƴ� �ǵ������� ������̴�" ��� �˷��ֱ� ���� new ���
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
		Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // Animal Cry
		d.Cry();    // Dog Cry

        //----------------------------------
        // �Ʒ� �ڵ尡 �ٽ� �Դϴ�.
        // => �޸𸮿� �ִ� ��ü ��ü�� "Dog"
        // => ������ ��ü�� ����Ű�� ������ "Animal" Ÿ��
        
        Animal ad = d;

        // �Ʒ� �ڵ�� � �޼ҵ带 ȣ���ұ�� ?
        // => � �޼ҵ带 ȣ���ϴ°� �������� ������� ?
        //    ��ü ��ü�� "Dog" �̹Ƿ� �������δ� Dog�� �½��ϴ�.
        ad.Cry(); // ?

        // java, python, swift ���� ��κ��� ��ü������ : Dog Cry ȣ��
        // C++/C# : Animal Cry
	}
}

