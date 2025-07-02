// 02_static7-3.cs ==> static6번복사해오세요

using static System.Console;

class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d)
    {
        (year, month, day) = (y, m, d);
    }
}

class Program
{
    public static void Main()
    {
        // 오늘 날짜로 초기화된 "today" 라는 객체를 만들어 보세요

        // 방법 #1
        // => 아래 처럼 만들면 미래에 실행하면 오늘 날짜가 아니다.
        Date today = new Date(2025, 7, 2);


        // 방법 #2. 아래 처럼 만들어야 한다.

        // int y = 올해의 년도를 구하는 프로그램 코드;
        // int m = 현재월 구하는 프로그램 코드;
        // int d = 현재일 구하는 프로그램 코드;
        Date today = new Date(y, m, d);


        // 방법#3. "방법#2" 를 해주는 static method 가 있으면 어떨까 ?
        Date today = Date.Today();
    }
}

