string s1 = "AAA"; // intern pool 에 있는 문자열
string s2 = "AAA"; // 위와 동일한 문장열을 가리킴(동일주소)

string s3 = new string("AAA"); // intern pool 아님
                                // 다른 메모리에 있는 문자열

// 생각해볼 문제 : string 사용자는 아래 코드가 true/false 중 어떤것을
//               기대 할까요 ?
// => 모두 "AAA" 문자열이므로 
Console.Write($"{s2==s3}"); // True

// 위 결과로 알수 있는 것
// == 는 원래 동일 객체 조사
// 그런데, string 은 동일 상태조사!
// 즉, string 이 == 를 다시 만들어서 사용한다는 의미

// 이렇때 실제 같은 객체인지 알고 싶다면 object.ReferenceEquals()
Console.Write($"{object.ReferenceEquals(s2, s3)}"); // False
Console.Write($"{object.ReferenceEquals(s1, s2)}"); // True