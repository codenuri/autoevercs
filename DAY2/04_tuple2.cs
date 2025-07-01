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
var t4 = (1, 2); // t4 의 타입은 ?
var t5 = (1);    // t5 의 타입은 ?





// #2. 요소 접근
var t2 = (1, 2, 3);



// #3. Named Member
(int,     int,     int)       v3 = (1,2,3); 


