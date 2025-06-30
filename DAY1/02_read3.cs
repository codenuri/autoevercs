using System;

// 핵심 : 입력 버퍼 - 중요한 개념.. 모든 언어가 거의 동일한 개념

// ReadLine() : 입력버퍼에서 개행문자가 나올때 까지 모두 꺼내고
//				개행 문자 제거

// Read() : 입력 버퍼에서 한문자 꺼냄

// Read 또는 ReadLine 사용시

// 1. 입력 버퍼에 데이타가 있는지 조사

// 2. 없다면 "키보드에서 입력 버퍼로 입력 받는 루틴 수행"
//    => enter 키 입력시, 입력된 내용을 버퍼에 담고, 루틴 종료

// 3. ReadLine()
//    => 버퍼에서 한줄 꺼내고, 개행 제거


// 4. Read()
//    => 버퍼에서 한자 꺼내기






Console.Write("input 1 >> ");
string s = Console.ReadLine();	 // 입력 대기
Console.WriteLine(s);			 // "ABCD"	


Console.Write("input 2 >> ");
int n = Console.Read();		// 1. 입력 버퍼가 비었으므로 다시 대기
							// 2. "ABCD" 입력시
							// 3. "A" 만 꺼내 가고
							// 4. 입력 버퍼에는 "BCD" 남음
							
Console.WriteLine("{0}, {1}", n, (char)n); 	//"A"


Console.Write("input 2 >> ");
n = Console.Read();		// 핵심
						// 1. 아직 입력 버퍼에 "BCD" 남아 있다
						// 2. 키보드에서 => 입력 버퍼에 담는 루틴 실행안됨
						// 3. 입력 버퍼에서 "B" 꺼내감.
						// 즉, 이순간은 대기가 없다


Console.WriteLine("{0}, {1}", n, (char)n);	
 

