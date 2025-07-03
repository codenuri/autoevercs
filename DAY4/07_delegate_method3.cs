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
		MyFunc m2 = M2; // error. 인자 타입이 다름
		MyFunc m3 = M3; // error. 반환 타입이 다름.
		MyFunc m4 = M4; // ok..   인자의 이름은 상관없음. 갯수와 타입이중요
	}
}
