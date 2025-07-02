using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // #1. int.Parse() : 문자열을 정수로 변경
        int n1 = int.Parse("10");    // ok. 성공
        int n2 = int.Parse("Hello"); // 실패. 예외 발생


        // int.Parse() : 실패시 예외 발생, 처리하지 않으면 비정상종료
        // int.TryParse() : 성공한 결과한 결과는 반환값으로
        //                  성공/실패 여부는 2번째 인자에 담아 줍니다.

        bool b = false;
        int n3 = int.TryParse("Hello", ?? b  );
    }
}