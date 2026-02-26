using System.Diagnostics;
using static System.Console;

// 실패를 호출자에 보고하는 방법

// C 언어 : 반환값으로 실패를 전달

class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        bool success = false;

        if (success == false)   // 실패라고 가정
            return false;        

        return true; // 성공
    }

    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        bool ret = db.Backup();

        if ( ret == false)  { }

        db.Remove();
    }
}
