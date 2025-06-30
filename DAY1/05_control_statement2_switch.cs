using System;

// 핵심 : switch 문
// if     : 참/거짓에 의한 분기
// switch : 값에 의한 분기

int num = 1;

switch( num )
{
    case 1: 
        Console.WriteLine("one");
        break;

    case 2:
        Console.WriteLine("two");
        break;

    // default 는 생략 가능
//    default:
//        Console.WriteLine("other");
//        break;
}

// C# 의 switch 는 C보다 아주 막강합니다.
// => switch 패턴 매칭이라는 분야가 있습니다.
object obj = 3.4; // object : 모든 타입의 값을 담는 도구

switch (obj)
{
    // 값이 아닌 타입 조사
    case int:    Console.WriteLine("int"); break;
    case double: Console.WriteLine("double"); break;

    // 값도 조사
    case "ABCD": Console.WriteLine("ABCD"); break;
}


