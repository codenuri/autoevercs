using System.Diagnostics;
using static System.Console;

// 핵심 
// 1. 함수(메소드)는 다양한 이유로 실패 할수 있습니다.

// 실패를 처리하는 방법
// #1. 실패한 함수에서 프로세스 종료
// => 나쁜 방법
// => 대부분 호출자에게 보고하는 것이 좋다. 

class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        // DB 내용을 서버에 백업

        // DB 백업에 실패하면 프로그램 종료
        Process p = Process.GetCurrentProcess();
        p.Kill();
    }

    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        db.Backup();    

        db.Remove();
    }
}
