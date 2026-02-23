// 교재 35 page ~ 

// 아래내용은 C#의 value vs reference 를 이해하기 위한 사전 지식

// 프로그램에서 사용되는 메모리의 종류
// 1. CODE MEMORY
// 2. DATA MEMORY

int n = 0; // 이런 변수가 data 메모리에 놓입니다.

// DATA 메모리는 아래의 3가지로 분류 합니다.
// 1. static storage : 
// 2. stack : 지역변수가 놓이는 공간, 크기 작고(1MB), 할당 속도 빠름
// 3. heap  : 크기가 크다(1G 이상, 자동증가도 가능), 할당 속도 느림

// 크기가 작고, 생성/파괴가 자주 발생하면 : stack 메모리
// 크기가 크고, 한번 만든후에 오래동안 사용 : heap 메모리

// stack vs heap 

// C/C++         : 타입사용자가 stack 을 사용할지 heap 을 사용할지 결정
// => 일반 개발자에게 모든 권한을 부여 한다.
int n = 10;                           // 스택에 4바이트 할당후 10 으로 초기화
int* p = (int*)malloc(sizeof(int));   // heap 에 4바이트 할당후 10 으로초기화

// C#, Java 의 철학
// => Rect 타입의 크기가 큰지 작은지는 누가 알수 있을까 ?
// => 1. 타입 사용자   2. 타입 설계자 => 답은 2번

// C#/Java/Swift : 타입설계자가 stack 을 사용할지 heap 을 사용할지 결정

// class : 데이타를 Heap 에 할당
// struct : 데이타를 Stack 에 할당