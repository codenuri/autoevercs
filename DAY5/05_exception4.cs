using System.Diagnostics;
using static System.Console;

// 예외를 잡는 방법

class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        bool success = false;

        if (success == false)
        {
            throw new Exception(); 
        }


    }

    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        // 예외 가능성이 있는 메소드 호출시 try {} 안에서

        try
        {
            db.Backup();
        }
        catch (Exception ex)
        {
            Console.WriteLine("DB Backup 실패");
            // 여기서 오류를 해결하려고 시도 합니다.
            // 해결할수 없다면 사용자에게 알리고 프로세스를 종료
            Process p = Process.GetCurrentProcess();
            p.Kill();
            // 여기서 종료하지 않으면 프로그램은 계속 실행
        }

        db.Remove();
    }
}
