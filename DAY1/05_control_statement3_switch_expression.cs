// �ٽ� : switch expression

int dayofweek = 1;

// �Ʒ� �ڵ�� switch statement �Դϴ�
// Ư¡ : s1 ������ ���� �����ؾ� �մϴ�.

string s1 = "";

switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}

// �Ʒ� �ڵ�� switch expression �Դϴ�.
// => expression �̹Ƿ� = �� ���ʿ� �ü� �ֽ��ϴ�.

string s2 = dayofweek switch
				{
					0 => "sun",
                    1 => "mon",
					2 => "tue",
					_ => "unknown",  // _�� default �ǹ�									 
                };
 
// switch expression �� �Ѱ��� ���� ������ �ϹǷ�
// => _ �� �����Ҽ� ����.

// C# �� if �� expression �� �ƴմϴ�. ������
// Rust ���� if �� expression �Դϴ�.
// Rust �ڵ�

// let ret = if n == 1 { 0 } else { 1 }; // else ���� �ȵ�

// let �� C#�� var

// ���� ���ο� ���� "����� expression" ȭ �ϰ� �ֽ��ϴ�.