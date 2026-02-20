using static System.Console;

// casting
double d  = 3.4;
int    n1 = d;      // error. 데이타 손실이 발생하는 변환은 암시적 변환안됨

int n2 = (int)d; // ok. 명시적 캐스팅
				 //	n2 는 3 으로 초기화

WriteLine(n2); // 3				

