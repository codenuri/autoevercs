using static System.Console;

// #1. 함수는 기본 적으로 한개의 값을 반환 합니다.
string Get1()       
{
    return "john";
}

string ret1 = Get1();  

// #2. 2개이상을 반환하고 싶으면 tuple 사용

(string, int, int) Get2()
{
    return ("john", 30, 180); // 이름, 나이, 키
}

var ret2 = Get2(); // ret2는 결국 tuple 타입 (string, int, int)

WriteLine($"{ret2.Item1}"); // 이름
WriteLine($"{ret2.Item2}"); // 나이


// #3. Named Member 가 좋습니다.

(string Name, int Age, int Height) Get3()
{
    return ("john", 30, 180); 
}

var ret3 = Get3(); 

WriteLine($"{ret3.Name}"); // 이름
WriteLine($"{ret3.Age}"); // 나이