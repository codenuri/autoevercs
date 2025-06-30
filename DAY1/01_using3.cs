//using System; // 현재 파일에서만 System 이름 없이 사용가능
//global using System; // 프로젝트내의 모든 파일에 적용됨
                     // (단, 이소스도 같이 빌드에 포함되어야 함)

// global.cs 때문에 아래 처럼 사용가능합니다.
// => global.cs 와 using3.cs 빌드 포함되어야 합니다.
Console.WriteLine("AAA");

// visual studio 2022 이전
// => 사용자가 직접 global.cs 같은 파일을 만들어야 했습니다

// visual studio 2022 이후
// => 프로젝트 생성시 자동으로 "global.cs" 유사 파일이 추가됩니다
// => DAY1//obj//debug//net8.0 에서
// => DAY1.globalusing.g.cs 열어 보세요
