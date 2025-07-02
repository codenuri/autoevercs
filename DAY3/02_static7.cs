using static System.Console;

class Date
{

    private int year;
    private int month;
    private int day;

    // 아래 한줄이 이번 소스 핵심
    // => 월별 날짜 수는 "날짜 객체 마다 따로 만들필요 없습니다."
    // => 모든 날짜 객체가 공유하기 위해 static field 로!!
    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    // 1월 날짜수 : days[0]
    // 2월 날짜수 : days[1]


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
    public Date AddDays(int ds)
    {
        Date temp = new Date(year, month, day + ds);

        return temp;
    }
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 7, 2);

        // d1 부터 1000일 뒤는 언제일까 ?
        Date d2 = d1.AddDays(1000);
    }
}