using static System.Console;

// #1. tuple 타입과 생성 방법
int n = 0;

int[] arr = { 1, 2, 3 };   // 배열 타입   : Type[]
                           // 배열 초기화 : {} 사용 

(int, int, int) t1 = (1, 2, 3); // 튜플 타입  : (Type1, Type2, Type3)
                                // 튜플 초기화: = (값, 값, 값)


(int, double, string) t2 = (1, 3.4, "ABCD");

// tuple 의 경우 타입을 직접 표기하면 복잡해 보입니다.
// 그래서, "var" 를 많이 사용합니다.

var t3 = (1, 3.4, "ABCD");



// #2. 주의 사항
var t4 = (1, 2); // t4 의 타입은 ? (int, int) t4 = (1,2)
var t5 = (1);    // t5 의 타입은 ? int t5 = 1



// #3. 요소 접근 : Item1, Item2, Item3 이라는 속성으로 접근
var t6 = (1, 2, 3);

t6.Item2 = 10;

WriteLine($"{t6.Item1} {t6.Item2}"); // 1, 10


// #4. Named Member => 중요
(int,     int,     int)       t7 = (1,2,3); // unnamed tuple
(int one, int two, int three) t8 = (1, 2, 3); // named tuple

WriteLine($"{t7.Item2}"); // unnamed 는 이 방법만 가능

WriteLine($"{t8.Item2}"); // named 는 이렇게 해도 되고
WriteLine($"{t8.two}");   // 이렇게도 가능

