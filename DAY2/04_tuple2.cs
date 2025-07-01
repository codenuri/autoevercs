using static System.Console;

// #1. tuple Ÿ�԰� ���� ���
int n = 0;

int[] arr = { 1, 2, 3 };   // �迭 Ÿ��   : Type[]
                           // �迭 �ʱ�ȭ : {} ��� 

(int, int, int) t1 = (1, 2, 3); // Ʃ�� Ÿ��  : (Type1, Type2, Type3)
                                // Ʃ�� �ʱ�ȭ: = (��, ��, ��)


(int, double, string) t2 = (1, 3.4, "ABCD");

// tuple �� ��� Ÿ���� ���� ǥ���ϸ� ������ ���Դϴ�.
// �׷���, "var" �� ���� ����մϴ�.

var t3 = (1, 3.4, "ABCD");



// #2. ���� ����
var t4 = (1, 2); // t4 �� Ÿ���� ? (int, int) t4 = (1,2)
var t5 = (1);    // t5 �� Ÿ���� ? int t5 = 1



// #3. ��� ���� : Item1, Item2, Item3 �̶�� �Ӽ����� ����
var t6 = (1, 2, 3);

t6.Item2 = 10;

WriteLine($"{t6.Item1} {t6.Item2}"); // 1, 10


// #4. Named Member => �߿�
(int,     int,     int)       t7 = (1,2,3); // unnamed tuple
(int one, int two, int three) t8 = (1, 2, 3); // named tuple

WriteLine($"{t7.Item2}"); // unnamed �� �� ����� ����

WriteLine($"{t8.Item2}"); // named �� �̷��� �ص� �ǰ�
WriteLine($"{t8.two}");   // �̷��Ե� ����

