// Property �� �ٽ�
// 1. Getter/Setter �� ���ϰ� ����� ����
// 2. ����ڴ� Getter/Setter �� ����ϰ� �Ǵ°�������
//    ��ġ �ʵ�ó�� ���̰� �ȴ�.

// => ����ڴ� �ʵ� ó�� ����ϰ�
// => ������ "�޼ҵ� ó��" ����

// ��ӵ� ���¸� �ܿ��� �մϴ�.
// �ҹ��ڷ� �����ص� ������, �ڵ� ���ʴ� �빮��

// C# ����
// Ŭ�����̸� ù����, �޼ҵ� �̸� ù����, ������Ƽ�̸� ù���� : �빮��
// �ʵ��̸� : �ҹ���. 

class Person
{
    private int age;
    
    // �Ʒ� Age �� ()�� �����Ƿ� "�ʵ�" ó�� ���Դϴ�.
    // �׷���, {} �� �����Ƿ� "�޼ҵ�" ó�� ���Դϴ�.
    public int Age
    {
        get { return age; }
        set 
        { 
            if( age > 0 && age < 150)
                age = value; 
        }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10; // ���� �۾��̹Ƿ� Age Property ��
                     // set �κ��� ȣ��˴ϴ�.
                     // 10 �� ��ӵ� �̸��� value �� ����

        int n = p1.Age; // �д� �۾� �̹Ƿ� Age Property �� 
                        // get �κ��� ȣ��˴ϴ�.
    }
}
