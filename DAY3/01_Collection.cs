// Collection 
class Program
{
    public static void Main()
    {
        // Array : 크기를 변경할수 없다. 삽입/삭제 안됨
        int[] arr = { 1, 2, 3, 4, 5 };

        // List<>: 배열과 사용법은 유사
        //         크기를 변경할수 있다. 삽입/삭제 가능
        //         파이썬의 list 와 거의 동일(내부메모리 구조도 동일)
        // <타입> : generic 문법
        List<int> s = new List<int>();

        s.Add(1);
        s.Add(2);
        s.Add(3);

        // 접근은 배열과 동일하게 [] 연산자
        s[0] = 10;
        s[1] = 30;

        // C++, C#, java : 배열 개념도 있고 List 도 존재
        // 파이썬         : List 만 존재
        //                  numpy 라이브러리가 결국 "C 스타일 배열"을
        //                                          만든 라이브러리

        // List : 편리하지만 약간 느림
        // Array: 불편하지만 List 보다 빠릅니다.


    }
}

