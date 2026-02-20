using System;               // System 안에 있는 요소는 System 없이 사용가능
using static System.Console; // Console 의 static 메소드는 
                             // Console 없이 사용가능

// System  : namespace 이름( 파이썬의 모듈과 유사)
// Console : 클래스 이름
// Write   : Console 클래스의 static method

System.Console.Write("Hello, "); // 출력후 개행 안함
System.Console.WriteLine("C#");  // 출력후 개행

// using System 이 있다면 아래 처럼 가능
Console.WriteLine("AAA");

// using static System.Console 이 있다면 아래 처럼 가능
WriteLine("AAA");  // 파이썬의 println() 같이 일반 함수 처럼 사용