// 03_mutable.cs

// mutable   : 객체의 상태를 변경할수 있는것
// immutable : 객체의 상태를 변경할수 없는것

// #1. int 타입의 객체는 mutable 합니다.
int n = 10;
n = 20;    // ok


// #2. string 타입의 객체는 immutable 합니다.

string s1 = "abcd";

char c = s1[0]; // ok     Read 작업

s1[0] = 'x';    // error  Write 작업 안됨.
                // string 은 immutable

string s2 = s1.ToUpper();
            // s1 의 내용을 대문자로 만든 새로운 문자열 반환
            // s1 자체는 변경안됨

string s3 = "ABC";
s3 = "XYZ"; // 변경한것 아닌가요 ?
            // s3 = new string("XYZ") 의 의미




