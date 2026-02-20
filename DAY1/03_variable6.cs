using static System.Console;

int n1 = 10;
int n2 = 20;

// 변수 값을 화면에 출력하는 방법

// #1. 변수 1개 출력
WriteLine(n1);

// #2. 2개이상, 또는 서식화된 출력(파이썬과 동일한 방식)
WriteLine("n1 = {0}, n2 = {1}", n1, n2);

// #3. $ 문자열 사용
// => {} 안에 변수이름을 직접 표기할수 있다
WriteLine($"n1 = {n1}, n2 = {n2}");

