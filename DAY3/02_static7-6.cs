using static System.Console;

class Program
{
    public static void Main()
    {
        // C# 에 이미 날짜 클래스 있습니다.
        // DateTime : 날짜와 시간을 같이 보관하는 클래스

        DateTime dt1 = new DateTime(2025, 7, 2, 13, 0, 0);
        WriteLine(dt1);

        // #1. 오늘 날짜로 초기화된 today 객체 만들어서 출력해 보세요

//      DateTime today = DateTime.Today;  // 오늘 날짜 12:00
        DateTime today = DateTime.Now;    // 오늘 날짜 현재 시간
        WriteLine(today);


        // #2. 오늘 부터 1000일뒤 날짜 만들어서 출력해 보세요
        DateTime d2 = today.AddDays(1000);
        WriteLine(d2);


        // #3. 올해가 윤년인지 조사해 보세요
        // => 윤년조사 함수가 instance method 인지 static method 인지 확인해 보세요

//      bool b = today.IsLeapYear(); // error. instance method 에 없음.
        bool b = DateTime.IsLeapYear( today.Year );

        WriteLine(b);
    }
}


