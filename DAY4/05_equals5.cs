string s1 = "AAA"; // intern pool 에 있는 문자열
string s2 = "AAA"; // 위와 동일한 문장열을 가리킴(동일주소)

string s3 = new string("AAA"); // intern pool 아님
                                // 다른 메모리에 있는 문자열

// 생각해볼 문제 : string 사용자는 아래 코드가 true/false 중 어떤것을
//               기대 할까요 ?

Console.Write($"{s2==s3}"); // ?