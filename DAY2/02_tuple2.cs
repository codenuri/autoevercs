using static System.Console;

// #1. tuple 생성
int[]          arr = { 1, 2, 3 }; // 배열 타입 : Type[], 초기화 : {}
(int, int, int) t1 = ( 1, 2, 3 ); // 튜플 타입 : (Type1, Type2, ...), 초기화 : () 

(int, double, string) t2 = (1, 3.4, "ABC"); // ? 타입 만들어 보세요

// tuple 은 타입을 직접 표기하면 복잡해 보입니다.
// 그래서, var 를 많이 사용합니다
var t = (1, 3.4, "ABC"); // 앞으로는 수업시간에 이렇게 사용



// #2. 요소 접근 : Item1, Item2, Item3, ...
var t3 = (1, 2, 3);

t3.Item1 = 10;

Console.WriteLine("{}, {}", t3.Item1, t3.Item2)




// #3. Named Member
(int, int, int) v3 = (1, 2, 3);


