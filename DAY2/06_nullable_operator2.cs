using static System.Console;

// null conditional operator ( ?, ?[]) 

string s1 = "hello";
string s2 = null;

// #1. null �� ��ü�� �޼ҵ带 ȣ���ϸ� ���� �Դϴ�.
var ret1 = s1.ToString(); // ok. ��ü�� ����.
//var ret2 = s2.ToString(); // ��Ÿ�ӿ���(���� �߻�)


// #2. �����ϰ� ����Ϸ��� Ȯ���� ȣ���ϸ� �˴ϴ�.

if ( s2 != null )
{
    var ret3 = s2.ToString();
}

// #3. �ٽ�. �Ʒ� ������ �� �ڵ��� �ǹ� �Դϴ�.
var ret4 = s2?.ToString();

// s2 != null �̸� s2.ToString() ������ ����� ret4�� �ֱ�
// s2 == null �̸� s2.ToString() �������, ret4 ���� null ��.
// ��, s2 �� null �� �ƴҶ��� �޼ҵ� ȣ���� �޶�.


