using static System.Console;

// 58 page �� �׸�

// int  : ���� �Ѱ� �� ����
// int? : ���� �Ѱ� �� ���� + bool �� ����

// int? �� int �� �����Ѵ�.

// 58 page �׸� �����ؼ� �Ʒ� �ڵ� ���� ���� ������ ������
int n = 0;
int? n1 = n; // ok

// int <= int?
int n2 = n1; // error

int n3 = (int)n1; // ok.
                  // ��, n1 == null (n1.hasValue �� false)��� ����(���ܹ߻�)


// �����ϰ� �Ϸ���
// #1. ������ ĳ����
//if ( n1 != null )
if ( n1.hasValue )
{
    int n4 = (int)n1;
}

// #2. Nullable �� GetValueOrDefault() �޼ҵ� ���
int n5 = n1.GetValueOrDefault(9); // n1 != null �̸� n1 �� ������
                                  // n1 == null �̸� 9
int n6 = n1.GetValueOrDefault();  // n1 == null �̸� int �� ����Ʈ��(0)