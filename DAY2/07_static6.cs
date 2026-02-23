using static System.Console;

class Date
{
    // 강의에서는 간단히 하기 위해 auto-impl 사용
    // 복습시에는 유효성 여부를 검증하도록 변경해 보세요
    public int Year { get; set; };
    public int Month { get; set; };
    public int Day { get; set; };

    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


    public Date(int y, int m, int d) => (Year, Month, Day) = (y, m, d);


    public Date AfterDays(int ds)
    {
        Date tmp = new Date(Year, Month, Day + ds); 
                                                    
        return tmp;
    }
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 2, 23);

        // 5월이 몇일까지 있는지 알고 싶다
        // 다음중 사용자 입장에서 편한 코드는 ?

        // 방법 #1. 5월로 초기화된 객체를 만들어서 메소드 호출
        Date d = new Date(2025, 5, 1);
        int n1 = d.HowManyDays();

        // 방법 #2. 객체 없이 클래스 이름으로만 호출가능한 메소드 사용
        int n2 = Date.HowManyDays(5);

    }
}