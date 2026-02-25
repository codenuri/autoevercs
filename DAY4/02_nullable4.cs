using static System.Console;

// null-coalescing operator (?? 연산자)

int?   n1 = null;

// n1 : int? 타입입니다.
 
int n2 = n1;    // error

int n3 = n1.GetValueOrDefault(); // ok
int n4 = n1 ?? 0; // 위와 동일 (실전에서 주로 사용)


// string 은 reference type 이므로 ? 가 없어도 null 가능
string s1 = null; 
string s2 = s1;  // s2 도 null
string s3 = s1 ?? "Unknown";  // s3 은 "Unknown"



