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

n1 = 3.4; // C/C++ : ��������, ��, 3.4 �� �ƴ� 3�� ����.
          //         0.4 �� ����Ÿ �ս�
          //         C/C++�� ������ �Ѱ�, �ʹ��������� ���� ���
          //         C : 1960��� ź��, C++ : 1983 ��

            // C#, Java, Rust : error
            //                  ��, ĳ�����ϸ� ����

            // Python         : ok 
            //                  0�� 3.4 �� �ٸ� �޸�
            //                  Post It

// C# ���� �Ǽ����� ������ �޸𸮿� �������� ĳ���� �ʿ�
n1 = (int)3.4;// ok




// 3. nameof
int color = 100;

WriteLine($"{color}");          // 100. ��, ������ ���
WriteLine($"{nameof(color)}");  // "color" ���, ��
                                // �����̸��� ���ڿ���. 

WriteLine($"color"); // �׳�, �̷��� �ϸ� �ȵǳ��� ?
                     // ������ �ڵ忡���� ���� �̸��� �𸣴� ��찡 �ֽ��ϴ�.




