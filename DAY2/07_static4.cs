using static System.Console;

// 프로그램에서 날짜 를 많이 사용한다.
// => "Date" 라는 타입을 설계 하자

class Date
{
    // #1. 필드는 private 으로 보호
    private int year;
    private int month;
    private int day;

    // #2. getter/setter 제공
    // => C# 에서는 property 가 관례
    public int Month
    {
        get => month;
        set { if (value > 0 && value < 13) { month = value; } }
    }

    // 과제 : 복습할때 Year, Day 도 만들어 보세요.

    // #3. 생성자로 필드 초기화.
    // => 대부분의 경우 코딩 관례!
    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 2, 23);

        Console.WriteLine(d1.Month); // 2
    }
}