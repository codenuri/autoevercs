using static System.Console;

// #1. 함수는 기본 적으로 한개의 값을 반환 합니다.
string Get1()
{
    return "john";
}

string ret1 = Get1();

// #2. 함수에서 2개이상의 값을 반환할때는 주로 tuple 사용
(string, int) Get2()
{
    return ("john", 20);
}

var ret2 = Get2();
Console.WriteLine("{0}, {1}", ret2.Item1, ret2.Item2);


// #3. Named Member 가 좋습니다.
(string Name, int Age) Get3()
{
    return ("john", 20);
}

var ret3 = Get3();
Console.WriteLine("{0}, {1}", ret3.Name, ret3.Age);

