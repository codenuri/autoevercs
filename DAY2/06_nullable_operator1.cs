using static System.Console;

// null-coalescing operator (?? ������) - 61page

int?   n1 = null;

 
// int n2 = n1;    // error

int n3 = n1.GetValueOrDefault(); // n1 != null �̸� n1 �� ��
                                 // n1 == null �̸� 0 ��ȯ

int n4 = n1 ?? 0; // �ٽ� : ���ڵ尡 ���� ����



// string �� reference type
string s1 = null;
string s2 = s1;     // ok. s2 �� ��ü ����.

string s3 = s1 ?? "Unknown"; // ���� s1 == null �̹Ƿ� 
                             // s3 �� "Unknown" ��ü����Ŵ



