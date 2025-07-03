using static System.Console;

// 예외 개념

// 모든 함수는 실패 할수 있습니다.
// 실패시 호출자에게 보고해야 합니다.

// C 언어 : 반환 값으로 실패를 알려 줍니다.

class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        return false; // 실패했다고 가정..

        // return true; // 성공했다면 true 반환
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
