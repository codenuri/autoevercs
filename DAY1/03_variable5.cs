using static System.Console;

// 03_variable5.cs

// #1. ������ ��� ���(9 page)
int a = 3;
double b = 3.4;

// 1. ������ �Ѱ� ���

Console.WriteLine(a); // 3


// 2. ������ ������ ���Ŀ� �°� ���
Console.WriteLine("a = {0}, b = {1}, a = {0}", a, b);


// 3. C# 6.0 ���� �������ڿ�($�ν����ϴ� ���ڿ�, Interpolated string) ��밡��

Console.WriteLine($"a = {a}, b = {b}, a+b = {a + b}");

// ���� : ���̽�
//println("a = {0}, b = {1}, a = {0}" % (a, b));





// #2. casting �̾߱�
int n1 = 0;     // n1 ������ ��� 4����Ʈ ũ�� "�ڽ�"

n1 = 3.4; // ? 





// nameof
int color = 100;
string s = "abcd";
string name = nameof(color);

WriteLine($"{nameof(color)} : {color}");				
*/


