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

    public static Date Today()
    {
        // 아래 처럼 하지말고 현재의 년월일을 구하는 기술 사용해야 합니다.
        Date temp = new Date(2025, 7, 2);

        return temp;
    }
}

class Program
{
    public static void Main()
    {
        // 이제 사용자는 아래 처럼 사용하게 됩니다.
        // C++/Java/Swift 등에서도 아주 널리 사용됩니다.
        Date today = Date.Today();
    }
}

