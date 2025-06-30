using static System.Console;

// 03_variable5.cs

// #1. 변수값 출력 방법(9 page)
int a = 3;
double b = 3.4;

// 1. 변수값 한개 출력

Console.WriteLine(a); // 3


// 2. 여러개 변수를 서식에 맞게 출력
Console.WriteLine("a = {0}, b = {1}, a = {0}", a, b);


// 3. C# 6.0 부터 보간문자열($로시작하는 문자열, Interpolated string) 사용가능

Console.WriteLine($"a = {a}, b = {b}, a+b = {a + b}");

// 참고 : 파이썬
//println("a = {0}, b = {1}, a = {0}" % (a, b));





// #2. casting 이야기
int n1 = 0;     // n1 정수를 담는 4바이트 크기 "박스"

n1 = 3.4; // C/C++ : 문제없다, 단, 3.4 가 아닌 3이 들어간다.
          //         0.4 의 데이타 손실
          //         C/C++의 단점중 한개, 너무오래전에 만든 언어
          //         C : 1960년대 탄생, C++ : 1983 년

            // C#, Java, Rust : error
            //                  단, 캐스팅하면 가능

            // Python         : ok 
            //                  0과 3.4 는 다른 메모리
            //                  Post It

// C# 에서 실수값을 정수형 메모리에 담으려면 캐스팅 필요
n1 = (int)3.4;// ok




// 3. nameof
int color = 100;

WriteLine($"{color}");          // 100. 즉, 변수값 출력
WriteLine($"{nameof(color)}");  // "color" 출력, 즉
                                // 변수이름을 문자열로. 

WriteLine($"color"); // 그냥, 이렇게 하면 안되나요 ?
                     // 복잡한 코드에서는 변수 이름을 모르는 경우가 있습니다.




