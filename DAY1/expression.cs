// expression.cs

// 모든 프로그래밍 언어에서 사용되는 개념
// statement vs expression

// statement(문장) : 실행단위가 되는 한줄의 문장
//             C/C++/C#/Java 의 세미콜론(;) 으로 끝나는 코드

// expression(표현식) : 하나의 값을 만드는 코드

int n = 3;

int a = (n + 2) * 3; // "n" 이라는 표현식의 값은 3
                     // "n+2"이라는 표현식의 값은 5
                     // "(n+2)*3"이라는 표현식의 값은 15

// expression 은 하나의 값을 만들기 때문에
// 변수 초기값으로 사용될수 있습니다.

// C 언어 : if, switch 는 모두 statement 입니다.
//          expression 이 아닙니다.

// C# 언어 : switch 는 statement 일수도 있고
//           expression 이 될수도 있습니다.