// java, C#, Swift 에서
// 문자열 타입은 2개가 있습니다.
// 1. immutable string
// 2. mutable string

using System.Text;

string s1 = "ABC"; // immutable, 절대 변경할수 없음

StringBuilder s2 = new StringBuilder("XYZ"); // mutable 변경가능
                                             // 단축표기법 없음
                                             // new 만 가능
//s1[0] = 'X'; // error. immutable
s2[0] = 'X'; // ok