using static System.Console;

// 핵심 : 초기화되지 않은 변수는 쓰기만 가능.

int n;  // 초기값이 없다.

int a = 0;

a = n;			// error. n 을 읽는 코드. 초기값이 없었다.

WriteLine(n);	// error. 화면 출력도 결국 읽는 코드

n = a;	// ok. 쓰는 코드

a = n;  // ok. 읽는 코드지만, 윗줄에서 n 에 값이 들어있으므로
        //      이제 n 을 읽을수 있다.