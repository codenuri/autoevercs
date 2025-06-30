using System;

// C# : ������ �ϸ� "CIL" �̶�� �߰��� �����մϴ�.

// CIL �� ����� ���� C# �Ӿƴ϶� VB, C++ � �����մϴ�.
// ���� 4 page

// .net �� ����� ������ ����Ÿ Ÿ����
// CLR(����ӽ�)����� ���� �߽��ϴ�.
// => CTS(Common Type System)
// => C#, VB, C++/CLI ���� ����� ��ü Ÿ���� CTS �� �����Դϴ�.


// #1. �Ʒ� 3���� ������ �����մϴ�.
int   n1 = 0;
System.Int32 n2 = 0;

Int32 n3 = 0;   // ok. using System �� �����Ƿ� �̷��Ե� ����.

System.int   n4 = 0;  // error.
                      // System �ȿ� �ִ°��� Int32
                      // int �� System �ȿ� �ִ°� �ƴ�
                      // Ű����(��ӵ� ����)

// "double" �� System.Double �� �����Դϴ�.
// �Ʒ� 3���� �Ϻ��� ����
double d1 = 0;
Double d2 = 0;
System.Double d3 = 0;

// "string" �� System.String �� ����
string s1 = "A";
String s2 = "A";
System.String s3 = "A";

// 29 page ǥ ����