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
var t4 = (1, 2); // t4 �� Ÿ���� ?
var t5 = (1);    // t5 �� Ÿ���� ?





// #2. ��� ����
var t2 = (1, 2, 3);



// #3. Named Member
(int,     int,     int)       v3 = (1,2,3); 


