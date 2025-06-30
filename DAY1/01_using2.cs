
// System  : namespace 이름( 파이썬의 모듈 개념)
// Console : class 이름
// WriteLine : method(함수) 이름 ( static method )

using System; // System 안에 있는 모든 요소를 "System 없이 사용"
              // python 의 "import 모듈이름" 개념

using static System.Console;
            // => System.Console 클래스 안의 static method 는
            //    클래스이름 없이도 사용가능
            // => 단, C# 6.0 부터 지원
System.Console.Write("Hello, ");
System.Console.WriteLine("C#"); 
System.Console.WriteLine("AAA");


// using System 때문에 아래 코드가 가능
Console.WriteLine("AAA");

// using static System.Console 때문에 아래 코드가 가능
WriteLine("AAA");




