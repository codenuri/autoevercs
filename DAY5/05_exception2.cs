using System.Diagnostics;
using static System.Console;

// 실패를 호출자에 보고하는 방법

// C 언어 : 반환값으로 실패를 전달

// 단점 : 호출자가 발생된 오류를 무시할수 있다
//       => 오류를 무시하고 계속 실행되면 더 큰 문제 발생
//       => DB 백업에 실패 했는데... DB 가 제거됨

// 호출자에게 반드시 오류를 처리하도록 강제 할수 없을까 ?
// => 오류 처리를 생략하면 프로그램 종료

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

        //if ( ret == false)  { }

        db.Remove();
    }
}
