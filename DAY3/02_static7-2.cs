using static System.Console;

class Date
{

    private int year;
    private int month;
    private int day;

    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public int Month
    {
        get { return month; }
        set
        {
            if (value < 1 || value > 12)
                throw new Exception();

            month = value;
        }
    }

    public Date(int y, int m, int d)
    {
        (year, month, day) = (y, m, d);
    }

    public Date AddDays(int ds)
    {
        Date temp = new Date(year, month, day + ds);

        return temp;
    }
    public static int HowManyDays(int m)
    {
        if (m < 1 || m > 12)
            throw new Exception();

        return days[m - 1];
    }
    //----------------------------------------------
    // 이번 핵심 소스는 여기부터!!

}

class Program
{
    public static void Main()
    {
        Date today = new Date(2025, 7, 2);

        // 윤년인지 조사하는 IsLeapYear() 를 제공하려고 합니다.
        // 어떤 방법이 좋을까요 ?

        // #1. instance method
        bool b1 = today.IsLeapYear();

        // #2. static method
        bool b2 = Date.IsLeapYear(2025);
    }
}