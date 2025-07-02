class Program
{
    private int data = 0;

    public static void Main()
    {
        Program pg = new Program();
        pg.IMethod();

        Program.SMethod();
    }

    public static void SMethod()
    {
        data = 10;
    }

    public void IMethod() 
    {
        data = 10;
    }

}