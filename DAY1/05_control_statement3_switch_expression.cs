// 핵심 : switch expression

int dayofweek = 1;

string s1 = "";

// 일반적인 방식의 switch 사용 
// => C/C++/Java 와 유사
switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}

// C# 언어가 가진 switch 의 특징
string s2 = dayofweek switch
			{
				0 => "sun",
				1 => "mon",
				2 => "tue",
				_ => "unknown",
			};