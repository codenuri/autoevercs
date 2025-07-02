// 02_static7-3.cs ==> static6번복사해오세요

using static System.Console;

class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d)
    {
        (year, month, day) = (y, m, d);
    }
    // Property 도 static 으로 할수 있습니다.
    public static Date Today
    {
        get 
        {
            Date temp = new Date(2025, 7, 2);
            return temp;
        }
    }
}

class Program
{
    public static void Main()
    {
        // 아래 코드 차이점 생각해 보세요
        // 어떤 코드가 사용시 편할거 같으세요 ?
        // C# 의 선택은 ?

//      Date today1 = Date.Today(); // static method
        Date today2 = Date.Today;   // static property 
    }
}


// 복습할때 "Date" 클래스 하나의 파일에
// => 배운 내용을 모두 넣어서 완전한 클래스로 설계해 보세요