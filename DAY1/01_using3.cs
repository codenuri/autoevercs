
// using2.cs 
// using3.cs 
// 모두 빌드 포함하세요
// 나머지는 모두 빌드 제외

Console.WriteLine("Hello"); // A
WriteLine("Hello");         // B

// using2.cs 를 빌드에서 제외 해 보세요
// 왜 B는 에러인데, A 는 에러가 없나요 ?

// => C#10.0 부터 obj/debug/net.10/프로젝트이름.GlobalUsing.g.cs 파일 자동생성됨
//    이안에 "global using" 소스 있음.
//    컴파일시 같이 컴파일됨.