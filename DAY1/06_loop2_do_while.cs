using static System.Console;

// �ٽ� : do ~ while

// while    : ���� ���� ����
// do-while : ������ �ѹ� ������ ���� ����

int cnt = 20;

while (cnt < 10) // ���� false. �Ʒ� ���� ����ȵ�
{
    WriteLine($"{cnt}");

    ++cnt;
}


do
{
    WriteLine($"{cnt}");

    ++cnt;
} while (cnt < 10); // ���� false �� �� ���� ����