// 00_entry4.cs

// C# 은 "함수 오버로딩" 을 지원합니다.
// => "인자 타입이 다르면" 동일 이름의 함수를 여러개 만들수 있다.
// => 파이썬은 "함수 오버로딩" 문법 지원 안함.

// 그런데, 왜 아래 코드가 에러 일까요 ?
void foo(int a)
{
}

void foo(double a)
{
}

System.Console.WriteLine("A");

//======================================================
// 에러의 원인 : 위 코드가 소스의 전부가 아닙니다.
// => 항상 컴파일러가 추가한 코드를 생각해야 합니다.
// => 즉, 위 코드는 아래 코드로 변경됩니다.

class CompilerGeneratedName 
{
    public static void Main()
    {
        // 이 위치에 사용자가 만든 코드를 넣게 됩니다.
        // => 결국 foo 는 "함수 안에 있는 함수(nested function)" 입니다
      
        void foo(int a)
        {
        }
        void foo(double a)
        {
        }
        System.Console.WriteLine("A");
    }
}

// C# 언어
// => 함수 안에 함수를 만들수 있다.(nested function)
// => 단, nested function 은 오버로딩 될수 없다.
//    즉, 동일이름 함수를 여러개 만들수 없다.

// 위와 같은 이유로 학습시 혼란에 빠질수 있습니다.
// => 간단한 코드를 제외한 대부분의 복잡한 문법사용은
// => Top Level 로 하지 마세요.. 