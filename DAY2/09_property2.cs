class Person
{
    private int age;
    
    // �Ʒ� Age �� ()�� �����Ƿ� "�ʵ�" ó�� ���Դϴ�.
    // �׷���, {} �� �����Ƿ� "�޼ҵ�" ó�� ���Դϴ�.
    public int Age
    {
        get { return age; }
        set { age = value; }
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
