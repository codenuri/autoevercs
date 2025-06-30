// 01_using4.cs
// 정리

// #1. 예전에는 아래와 같은 코드를 작성해야 했습니다.
// using System;

// #2. 하지만 visual studio 2022 부터는
// => // => DAY1//obj//debug//net8.0/DAY1.globalusing.g.cs 때문에
// => 위코드 없어도 아래 처럼 사용가능합니다.
Console.WriteLine("AA");


// #3. 단 아래처럼 Console 도 제거하려면
// 사용자가 직접 "using static System.Console" 해야 합니다.
WriteLine("A"); // 현재는 에러

