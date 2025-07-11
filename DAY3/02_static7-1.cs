﻿using static System.Console;

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
    public static int HowManyDays(int m)
    {
        if ( m < 1 || m > 12)
            throw new Exception();
        
        // 7월의 날짜수는 days[6] 입니다.
        return days[m - 1];

        // 위 구현은 2월일때 윤년이 고려되지 않은 구현.. 
    }
}

class Program
{
    public static void Main()
    {


        // 7월이 몇일까지 있는지 알고 싶다.
        // 다음중 좋은 코드는 ?
        // => 년월일 의 모든 데이타가 필요한것은 아닙니다.
        // => 2번이 좋습니다.
        // 방법 #1. 7월 을 가진 객체를 만들어서 메소드 호출
//      Date d1 = new Date(2025, 7, 2);
//      int ds = d1.HowManyDays();

        // 방법 #2. 객체없이 호출가능하게, 인자로 7월 전달
        int ds = Date.HowManyDays(7);

        //------------------------
        // 특정 날짜의 내일 날짜를 구하는 Tomorrow() 를 만들려고 합니다.
        // => instance method 로 할까요 ? static method 로 할까요 ?
        // => 2025/7/2 의 내일

        Date today = new Date(2025, 7, 2);

        // 방법 #1. 객체가 이미 존재 할때 해당 객체의 내일을 구하기 위해
        // 아래 처럼 사용하게 하자.
        Date to = Date.Tomorrow(today.Year, today.Month, today.Day);


        // 방법 #2. 내일이라는 개념은 "기준날짜" 가 필요하다.
        // => instatnce method 로 하자
        Date to = today.Tomorrow();

        // method 내부에서 field 의 모든 정보를 사용해야 한다.
        // => instance method
        
        // method 내부에서 field 접근할 필요 없다.
        // => static method

        // 위 Tomorrow() 는 instance() 가 좋습니다.
        // => 복습할때 만들어 보세요
    }
}