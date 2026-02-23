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

    // static method
    // => 기준 객체(특정날짜를 담은 객체)와는 관련 없는 기능
    // => 단지, Date 관련된 기능을 구현하는 것
    public static int HowManyDays(int m)
    {
        // 복습시 m 이 유효한지 확인하는 코드 추가해 보세요( 0 < m < 13)
        return days[m - 1];
    }

    // 내일 날짜를 구하는 메소드
    // => 기준이 되는 객체를 만들고 호출해야 한다.
    // => instance method
    public Date Tomorrow()
    {
        Date tmp = new Date(Year, Month, Day + 1); // 잘못된 구현
                                        // 복습시 제대로 구현해 보세요
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
//      Date d = new Date(2025, 5, 1);
//      int n1 = d.HowManyDays();

        // 방법 #2. 객체 없이 클래스 이름으로만 호출가능한 메소드 사용
        int n2 = Date.HowManyDays(5);

        //---------------------------------
        // 내일 날짜를 알고 싶다
        // => 이 작업은 기준이 되는 날짜(객체) 가 필요 1. 없다 2. 하다 ?
        Date today = new Date(2025, 2, 23);
        Date tom = today.Tomorrow();   // instance method!

    }
}