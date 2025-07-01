// �ٽ� #1. property ����� ����ϴ� ��� �˾� �μ���
// => �޼ҵ�� �ʵ��� Ư¡�� ������ ���� �ֽ��ϴ�.

// #2. ����� ������ �ʵ� ó�� ��������
//     ������ �޼ҵ� ���� �Դϴ�.
//     => ��� ����ؼ� �� ��ȿ�� ���� ����

// #3. ����!!!
// => Property �� ������ �ϸ�
// => set_Age(), get_Age() �Լ��� �����ϰ� �˴ϴ�.
// => �ᱹ setter/getter ����� �Ͱ� ����

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

    // �Ʒ� ó�� ����ڰ� ���鶧
    // => property �� ������ setter �� �̸��� �浹�Ǿ
    // => �����Դϴ�. �Ʒ� �κ� �Ǵ� �� set{} �κп��� ����
    public void set_Age(int value)
    {

    }
}
class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10;    // ������ �Ǹ� p1.set_Age(10)
        int n = p1.Age; // int n = p1.get_Age()
                        // �� ����Ȱ�    
    }
}
