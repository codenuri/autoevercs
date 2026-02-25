using static System.Console;

delegate void MyFunc(int arg);

class Program
{
	public static void M1(int arg)    {}
	public static void M2(double arg) {}
	public static int  M3(int arg) => 0;
	public static void M4(int other)  {}

	public static void Main()
	{
        // 에러를 찾아 보세요

        MyFunc m1 = M1; // ok
		MyFunc m2 = M2; // error
		MyFunc m3 = M3; // error
		MyFunc m4 = M4; // ok

		// 핵심 : delegate 에 담으려면
		// => 함수의 반환 타입, 인자 갯수, 인자 타입이 일치해야 한다
		// => 인자의 변수명은 상관없다
	}
}
