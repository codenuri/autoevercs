using static System.Console;




// ����� ���� Ÿ�Կ� ���ؼ� CompareTo �� �����Ϸ���
// => �׳� ������ �����ص� ������..

// �ٸ� C# Ÿ�԰��� ȣȯ���� ����
// 1. IComparable �� ���� ��� ��������
// 2. ��Ģ�� "CompareTo" �����ϼ���

class Label :  IComparable
{
	private string title;
	
	public Label(string s) => title = s;


    public int CompareTo(object? obj)
    {
		Label other = (Label)obj;

		// Label �� title �ʵ� ��ü�� string �ε�
		// string ��ü�� CompareTo ����..
		return title.CompareTo(other.title);
    }
}



class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		// ����� ���� Ÿ���� Label �� ũ�� �񱳰� �ǵ��� �غ��ô�.
		int ret = d1.CompareTo(d2);
	}

    public static void M1(IComparable ic)
    {
    }
}


// ����
// C++ : ���� ��� ����
// C#/Java/Python : ���� ��� �ȵ�. ���� �������̽� ��Ӱ���

// Rust : ��� ��������(Traits ��� ��Ư�� ��� ���)