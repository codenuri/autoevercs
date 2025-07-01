using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

// �Ʒ� �ڵ�� a,b,c 3���� ������ t1 �̶�� Ʃ���� ����(construction) �Ѱ�
var t1 = (a, b, c);



// #2. deconstruction
int x, y, z;

// �Ʒ� �ڵ�� t1�̶�� tuple �� ���� ����, x, y, z �� ������(deconstruction)
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// �ٽ� : �� 3���� �Ʒ� ó�� ���ٷ� �Ҽ� �ֽ��ϴ�.
(x, y, z) = t1; // ���̽��� "x, y, z = t1" �̷���


// deconstruction �Ҷ�
// => ������ ������ �ص� �ǰ�, ����� ���ÿ� �ص� �˴ϴ�.
/*
int a1, b1, c1;
(a1, b1, c1) = t1;

(int a2, int b2, int c2) = t1; // ���� ����
*/



// #3. �Ʒ� 2���� �������� ? - 49page �Ʒ�
(int a1, int a2, int a3) tp = (1, 2, 3); 
        // tuple �� ���� �Ѱ�
        // tp �� tuple �ε� ����� �̸��� a1, a2, a3
        // ��, a1, a2, a3 �� ���� �� �ƴ� tuple ����̸�

(int b1, int b2, int b3)    = (4, 5, 6);
                    // (4, 5, 6) �̶�� tuple �� ���� 
                    // ����, b1, b2, b3 ��� ������ ������
                    // deconstruction
                    // b1,b2, b3 �� ���� int ����!

int b1 = 10; // error. ������ int b1 �����
int a1 = 10; // ok.    ���� int a1 �� ���� ���� �ƴ�


// #4. �� �����ϱ�
var t3 = (1,2,3);

// 1, 3 ��°�� ��� �ʹ�. 2��°�� �ʿ� ����.
// => _ ���
(int x, _, int y) = t3;