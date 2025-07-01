using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

// 아래 코드는 a,b,c 3개의 변수로 t1 이라는 튜플을 생성(construction) 한것
var t1 = (a, b, c);



// #2. deconstruction
int x, y, z;

// 아래 코드는 t1이라는 tuple 의 값을 각각, x, y, z 에 담은것(deconstruction)
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// 핵심 : 위 3줄을 아래 처럼 한줄로 할수 있습니다.
(x, y, z) = t1; // 파이썬은 "x, y, z = t1" 이렇게


// deconstruction 할때
// => 변수를 선언후 해도 되고, 선언과 동시에 해도 됩니다.
/*
int a1, b1, c1;
(a1, b1, c1) = t1;

(int a2, int b2, int c2) = t1; // 위와 동일
*/



// #3. 아래 2줄의 차이점은 ? - 49page 아래
(int a1, int a2, int a3) tp = (1, 2, 3); 
        // tuple 을 생성 한것
        // tp 는 tuple 인데 멤버의 이름이 a1, a2, a3
        // 즉, a1, a2, a3 는 변수 가 아닌 tuple 멤버이름

(int b1, int b2, int b3)    = (4, 5, 6);
                    // (4, 5, 6) 이라는 tuple 이 값을 
                    // 각각, b1, b2, b3 라는 변수에 담은것
                    // deconstruction
                    // b1,b2, b3 는 각각 int 변수!

int b1 = 10; // error. 위에서 int b1 선언됨
int a1 = 10; // ok.    위에 int a1 은 변수 선언 아님


// #4. 값 무시하기
var t3 = (1,2,3);

// 1, 3 번째만 얻고 싶다. 2번째는 필요 없다.
// => _ 사용
(int x, _, int y) = t3;