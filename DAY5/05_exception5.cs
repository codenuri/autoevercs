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

class NetworkException : Exception
{
    // 네트워크 장애 발생시 사용할 예외
    // 여기에서도 다양한 정보를 담기 위한 필드, 메소드 제공
}


class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        bool success = false;

//      if (...)
        {
            throw new NetworkException();  // 네트워크 장애
        }

//      if (... )
        {
            throw new DBBackupException();
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
        catch (DBBackupException ex)
        {
            Console.WriteLine("DB Backup 실패");
        }
        catch (NetworkException ex)
        {
            Console.WriteLine("NetworkException");
        }
        catch (Exception ex) // 위에서 잡히지 않은 모든 예외
        {                    // 모든 예외는 Exception 의 파생 클래스!
            Console.WriteLine("알수 없는 예외");
        }

        db.Remove();
    }
}
