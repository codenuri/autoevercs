// 다음 코드에서 에러를 모두 찾으세요
class Car
{
    private int speed = 0;
    private static int cnt = 0;

    public static void F1()
    {
        speed = 10; // ?
        cnt = 10;   // ?
    }
    public void F2()
    {
        speed = 10; // ?
        cnt = 10;   // ?
    }
}
class Program
{
    public static void Main()
    { 
    }
}