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

int a1, b1, c1;
(a1, b1, c1) = t1;

(int a2, int b2, int b3) = t1;








// #3. �Ʒ� 2���� �������� ?
(int a1, int a2, int a3) t2 = (1, 2, 3); 
(int b1, int b2, int b3)    = (4, 5, 6); 

