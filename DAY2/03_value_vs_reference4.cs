using static System.Console;

// C#�� ��� Ÿ���� �Ʒ� 2���� �Ѱ� �Դϴ�.(39 page ǥ )
// 1. Value Type        : struct, enum
// 2. Reference Type    : class, interface,  delegate

// �Ʒ� �ڵ带 ����
// 1. �޸� �׸��� �׸��� �־�� �ϰ�
// 2. ��� ����� �����Ҽ� �־�� �մϴ�.


// #1. int : value type, struct �� ����
int n1 = 10;
int n2 = n1; // �̼��� n2, n1 �� �ٸ� ��ü(����)

n1 = 20;

WriteLine($"{n1} {n2}"); // 20, 10


// #2. �迭 : reference type
// => 40 page �߰� �׸�.
// => ���� : swift �� �迭�� value type �Դϴ�.

int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;

WriteLine($"{x1[0]} {x2[0]}");	// 20, 1 






// #3. string 
string s1 = "AB";
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");  // ?, ? 