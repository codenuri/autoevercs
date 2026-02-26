using System.Diagnostics;
using static System.Console;

// 객체지향 언어들의 오류 처리 기술
// => 예외(exception) 이라는 기술 사용


class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        bool success = false;

        if (success == false)
        {
            throw new Exception(); // 실패 하면 예외를 던진다
        }

        
    }

    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        bool ret = db.Backup();

        //if ( ret == false)  { }

        db.Remove();
    }
}
