using static System.Console;

// ���(67page ~ )

// ��� ���α׷��� "��ӵ� entry point" ���� ����
// ���������� ����˴ϴ�.
// 1. �����帧�� �����Ϸ��� ���ǹ�(conditional statement) ���
// 2. �����帧�� �ݺ��Ϸ��� �ݺ���(iterative   statement) ���

// ���ǹ�
// C ���  : if, switch
// C# ��� : if, switch
// Python : if, match(3.12 �������� �߰�, switch �� ����) 

// �ݺ���
// C    : while, do-while, for
// C#   : while, do-while, for, foreach
// Python : while, for(C# foreach�� ����)


// �ٽ� : if ��

int score = 75;

// �ٽ� #1. ���̽��� () ��������������, C# �� �ʼ�!
//      2. C ���� ���๮���� 1���̸� {} ��������, C#�� �ʼ�

if (score > 70)
{
    WriteLine("Pass");
}
else if (score < 40)
{
    WriteLine("Fail");
}
else
{
    WriteLine("Reexam");
}

// ���� () �ȿ��� �ݵ�� bool Ÿ�Ը� �����մϴ�.
if ( score ) // C ��� ok. score�� 0�̸� false, 0 �ƴϸ� true
{            // C# error. (score != 0) ���� �ؾ� �Ѵ�.
}

