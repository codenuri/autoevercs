class Program
{
    private int data = 0;

    public static void Main()
    {
        Program pg = new Program();
        pg.IMethod();       // IMethod(pg)

        Program.SMethod();  // 컴파일 해도 인자 추가 안됩니다.(객체 없으므로)
                            // SMethod()

    
    }
    // 핵심 #1. 인스턴스 메소드는 컴파일 하면 this 가 추가되지만
    public void IMethod()   // void IMethod(Program this)
    {
        data = 10;  // this.data = 10  로 변경됩니다.
    }

    // 핵심 #2. 스태틱 메소드는 this가 추가되지 않는다.
    public static void SMethod()    // void SMethod()
    {
        data = 10;  // this.data = 10 으로 변경해야 되는데
                    // 이 메소드는 인자로 this가 추가되지 않으므로 
                    // this 를 사용할수 없다. 
                    // 컴파일 에러
    }
    // 참고) 아래처럼 만들고
    // Program.SMethod2(pg);   이렇게 하는 기술도 있긴합니다
    public static void SMethod2(Program self)
    {
        self.data = 10;
    }
}