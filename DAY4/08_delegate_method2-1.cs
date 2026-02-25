// 인스턴스 메소드(static 이 아닌 메소드)
// "객체.메소드이름()" 으로만 호출가능

// 컴파일시 아래 한줄 추가되어서 실행 시작
// "Program.Main()"

class Program
{
    private int color = 0;
    public void F1(int a) 
    {
        color = 10;

        Program.SF(0);
        SF(0);
    }
    public void F2(int a) // F2(Program this, int a)
    {
        // F2가 호출되었다는 것은 객체가 있다는 것
        // 그 객체 참조는 this
        // 그래서 여기서는 "this"를 사용해서 F1 호출
        this.F1(0);
        F1(0);

        Program.SF(0);
        SF(0);
    }
    public static void Main()
    {
        // 1. 아직 Program 객체를 만든적은 없다
        // 2. 여기서 F1 을 바로 호출하는 것은 안됨(객체가 없다)
        // 3. F1 을 호출하려면 객체가 필요 하다.
        Program pg = new Program();
        pg.F1(1);
        pg.F2(0); // F2(pg, 0)

        Program.SF(0);
        SF(0);
    }

    // static :어느위치에서는 "클래스이름.메소드이름()" 으로 호출 가능
    //         그런데, 자신의 메소드 에선느 "클래스이름"을 생략가능
    public static void SF(int a) { }
}