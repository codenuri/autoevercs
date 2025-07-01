using static System.Console;

// null-coalescing operator (?? 연산자) - 61page

int?   n1 = null;

 
// int n2 = n1;    // error

int n3 = n1.GetValueOrDefault(); // n1 != null 이면 n1 의 값
                                 // n1 == null 이면 0 반환

int n4 = n1 ?? 0; // 핵심 : 이코드가 위와 동일



// string 은 reference type
string s1 = null;
string s2 = s1;     // ok. s2 도 객체 없음.

string s3 = s1 ?? "Unknown"; // 현재 s1 == null 이므로 
                             // s3 는 "Unknown" 객체가리킴



