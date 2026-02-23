// 아래 2줄은 완전히 동일!!
// => 하지만 타입에 따라서 new와 단축 표기법의 동작이 다른 경우가 있다
int n1 = 0;
int n2 = new int();

// 메모리에 "AAA" 라는 문자열이 몇개 있을까요 ?

string s1 = "AAA";
string s2 = "AAA";
string s3 = new string("AAA");
string s4 = new string("AAA");
