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
    public bool IsLeapYear() 
    {
        // 멤버(필드)인 year 가 윤년이지 조사
        bool b = (year % 400 == 0)
                 || ((year % 4 == 0) && (year % 100 != 0));

        return b;
    }

    public static bool IsLeapYear(int y)
    {
        // 인자 y 가 윤년이지 조사
        bool b = (y % 400 == 0)
                 || ((y % 4 == 0) && (y % 100 != 0));

        return b;
    }

}


class Program
{
    public static void Main()
    {
        Date today = new Date(2025, 7, 2);

        // 윤년인지 조사하는 IsLeapYear() 를 제공하려고 합니다.
        // 어떤 방법이 좋을까요 ?

        // #1. instance method
        // => 객체가 존재 했다면 아래 처럼 편하게 사용
        // => 객체가 없던 상태에서 조사하려면, 조사를 위해 객체를 생성해야 한다
        bool b1 = today.IsLeapYear();


        // #2. static method
        // => 객체가 없어도 조사
        bool b2 = Date.IsLeapYear(2025);

        //=> 객체가 있었다면 아래 처럼
 //     bool b2 = Date.IsLeapYear(today.Year);

        // IsLeapYear()는 static method 가 좋은데
        // => istance, static 2개 모두 제공하는 경우도 있습니다.
    }
}