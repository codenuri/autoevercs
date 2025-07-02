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
    //----------------------------------------------
    // 이번 핵심 소스는 여기부터!!
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 7, 2);

        // 7월이 몇일까지 있는지 알고 싶다.
        // 다음중 좋은 코드는 ?
        int ds = d1.HowManyDays();
        int ds = Date.HowManyDays(7);
    }
}