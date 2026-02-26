using System.Diagnostics;
using static System.Console;

// 예외 클래스
// Exception : C# 에서 예외 던질때 사용하라고 제공하는 표준 타입
// => 보통 직접 사용하지 말고, 파생 클래스 만들어서 사용

class DBBackupException : Exception
{
    // 이 안에 에러의 원인을 최대한 보관하게 하세요
    public string backupfilename = "a.txt";
}

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

        try
        {
            db.Backup();                        
        }
        catch (Exception ex)
        {
            Console.WriteLine("DB Backup 실패");

        }

        db.Remove();
    }
}
