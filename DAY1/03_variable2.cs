using static System.Console;

// 핵심 : 초기화되지 않은 변수는 쓰기만 가능.
int n;  // <= 초기값이 없다

int a = 0;

a = n;			// error. 초기화되지 않은 n 을 읽을수 없다.
WriteLine(n);	// error. 화면 출력도 결국 읽는작업이 필요

n = a;	// ok. 쓰는 작업
a = n;  // ok. 읽는 작업이지만, 위 줄에서 이미 초기화됨.