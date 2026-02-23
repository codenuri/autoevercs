using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

// 아래 코드는 int 변수 3개로 tuple 을 만든것
// => 즉, 생성(construction)
var t1 = (a, b, c);


// #2. deconstruction
int x, y, z;

// 아래 코드는 t1이라는 tuple 의 값을 각각, x, y, z 에 담은것
// => 분해(파괴, deconstruction 이라는 용어 사용)
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// 위 코드를 아래 처럼 한줄로 표현가능
(x, y, z) = t1;

// 위 코드는 변수 x,y,z 를 먼저 선언후 사용한것
// 아래 처럼 선언과 분해를 동시에 해도 됩니다.
(int a, int b, int c) = t1;

int a;
int b;
int c;
(a, b, c) = t1; // 이 코드와 같은 것이 위 한줄의 코드



// #3. 아래 2줄의 차이점은 ?
(int a1, int a2, int a3) t2 = (1, 2, 3); // t2 라는 tuple 생성
                                         // 요소의 이름이 a1, a2, a3
(int b1, int b2, int b3)    = (4, 5, 6); // (4,5,6) 이라는 tuple 을분해
                                         // 해서, b1, b2, b3 에 담은것
                                         // b1, b2, b3는 변수 이름
                                            
t2.a1 = 10;
t2.a2 = 20;

