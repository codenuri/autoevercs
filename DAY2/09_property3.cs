// �ٽ� #1. property ����� ����ϴ� ��� �˾� �μ���
// => �޼ҵ�� �ʵ��� Ư¡�� ������ ���� �ֽ��ϴ�.

// #2. ����� ������ �ʵ� ó�� ��������
//     ������ �޼ҵ� ���� �Դϴ�.
//     => ��� ����ؼ� �� ��ȿ�� ���� ����

// #3. ����!!!


class Person
{
    private int age;


    public int Age
    {
        get { return age; }
        set
        {
            if (age > 0 && age < 150)
                age = value;
        }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10; 
        int n = p1.Age; 
    }
}
