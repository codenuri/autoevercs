// 핵심 : switch expression

int dayofweek = 1;

// 아래 코드는 switch statement 입니다
// 특징 : s1 변수를 먼저 선언해야 합니다.

string s1 = "";

switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}

// 아래 코드는 switch expression 입니다.
// => expression 이므로 = 의 왼쪽에 올수 있습니다.

string s2 = dayofweek switch
				{
					0 => "sun",
                    1 => "mon",
					2 => "tue",
					_ => "unknown",  // _는 default 의미									 
                };
 
// switch expression 은 한개의 값을 만들어야 하므로
// => _ 를 생략할수 없다.

// C# 의 if 는 expression 이 아닙니다. 하지만
// Rust 언어는 if 도 expression 입니다.
// Rust 코드

// let ret = if n == 1 { 0 } else { 1 }; // else 생략 안됨

// let 은 C#의 var

// 요즘 새로운 언어는 "제어문을 expression" 화 하고 있습니다.