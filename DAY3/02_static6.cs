// 02_static6.cs
using static System.Console;

// 프로그램에서 날짜 를 많이 사용한다.
// => "Date" 라는 타입을 설계 하자

class Date
{
    // #1. 날짜의 요소를 필드로!
    // => 날짜는 유효하지 않은 값이있다. private 으로 방어!
    private int year;
    private int month;
    private int day;

    // #2. setter/getter..
    // => C# 은 property 권장
    public int Month
    {
        get { return month; }
        set 
        { 
            if (value < 0 || value > 12) 
                return; 
            month = value; 
        }
    }

}

class Program
{
    public static void Main()
    {
        Date d1 = new Date();
    }
}