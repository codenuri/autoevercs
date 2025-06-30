using System;

// 핵심 : 입력 버퍼가 아닌 키보드로 부터 직접 입력 받기

Console.Write("press any key >> ");

// Console.Read() : 입력버퍼에서 한문자 꺼내기

// => 입력 버퍼가 비었다면
// => 1. "키보드에서 입력 버퍼에 입력받는 루틴 수행"
// => 2. enter 키 입력시 1번 루틴 종료 ===============> 이게 핵심
// => 3. 입력버퍼에서 한자를 꺼내서 n 에 넣기
//       ( "A" 를 꺼냈다면 아스키 코드인 65 를 n에 담기)

/*
int n = Console.Read();

Console.WriteLine(n); // 65
Console.WriteLine((char)n); // 'A'
*/

// Console.ReadKey() : 입력 버퍼가 아닌 키보드로 부터 직접 입력
// => enter 가 필요없이 한자 입력시 바로 리턴된다.

//ConsoleKeyInfo key = Console.ReadKey();   // 입력문자 echo 됨
ConsoleKeyInfo key = Console.ReadKey(true); // 입력문자 echo 안됨

Console.WriteLine(key.KeyChar); // <== 입력된 문자
