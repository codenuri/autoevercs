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
        Date today = Date.Today();
    }
}

