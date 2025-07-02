using static System.Console;

class Date
{

    private int year;
    private int month;
    private int day;

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
    //----------------------------------------------
    // 이번 핵심 소스는 여기부터!!

}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 7, 2);
    }
}