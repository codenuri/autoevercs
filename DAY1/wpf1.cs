

// C# 언어의 장점
// => 강력한 문법 + 풍부한 라이브러리(분야별 수천~수만개의 미리 만들어진 타입(클래스))

// WPF(Windows Presentation Framework)
// => GUI 용 라이브러리
// => Direct-X 엔진을 사용한 강력하고 유연한 GUI 작성 가능

// 프로그램에서 WPF 라이브러리 사용하려면

// 1. 프로젝트의 종류를 "WPF 응용프로그램" 으로 선택
// => 하지만, 이경우 자동생성되는 코드가 너무 복잡,
// => 처음 학습시는 권장 안함

// 2. 프로젝트의 종류는 "콘솔 응용프로그램" 으로 선택후
// => 프로젝트 설정 파일의 2곳만 수정 => 프로젝트 이름(DAY1Example) 클릭후 XML수정
// => 장점 : 자동생성되는 파일 단 1개, 한줄의 코드만 생성
// => 사용자가 가장 기본 코드부터 학습 가능

Console.WriteLine("Hello, World!");


// System.Windows.MessageBox 클래스의 static method를 사용하면 MessageBox를 나타낼수 있습니다.
MessageBox.Show("Hello");


// 파일이름 wpf1.cs로 변경