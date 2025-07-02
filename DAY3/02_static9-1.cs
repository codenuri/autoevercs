class Program
{
    public void M1() { }

    public static void M2() { }

    public static void Main()
    {
        // #1. 자신의 static method 호출
        Program.M2();   // ok. "클래스이름.static메소드()"
        M2();           // ok. 자신의 static 메소드는 클래스 이름 생략가능


        // #2. 자신의 instance method 호출 이야기.
//      M1(); // error. instance method 는 객체가 필요한다.
              // Main 은 객체 없이 호출된 함수안에 있는것

        Program pg = new Program(); //자신 타입의 객체를 만든후
        pg.M1(); // ok.. 
    }
}