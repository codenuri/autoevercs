using System;

// �ٽ� : switch ��
// if     : ��/������ ���� �б�
// switch : ���� ���� �б�

int num = 1;

switch( num )
{
    case 1: 
        Console.WriteLine("one");
        break;

    case 2:
        Console.WriteLine("two");
        break;

    // default �� ���� ����
//    default:
//        Console.WriteLine("other");
//        break;
}

// C# �� switch �� C���� ���� �����մϴ�.
// => switch ���� ��Ī�̶�� �о߰� �ֽ��ϴ�.
object obj = 3.4; // object : ��� Ÿ���� ���� ��� ����

switch (obj)
{
    // ���� �ƴ� Ÿ�� ����
    case int:    Console.WriteLine("int"); break;
    case double: Console.WriteLine("double"); break;

    // ���� ����
    case "ABCD": Console.WriteLine("ABCD"); break;
}


