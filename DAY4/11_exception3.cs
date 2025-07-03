using static System.Console;

// #1. 오류의 대한 자세한 정보를 담을수 있는 class 를 설계 하세요
// => C# 에서는 Exception 이라는 클래스로 부터 파생 받는 것을 권장

class DBBackupException : Exception
{
    // 다양한 멤버를 사용해서 실패 이유를 담을수 있게 하세요
    private string message;

    public DBBackupException(string s) => message = s;
}


// #2. 메소드가 실패하면 예외 객체를 던지세요(throw)


class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        return false;
    }
    public void Remove() => WriteLine("Remove DB");
}



class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        bool ret = db.Backup();


        db.Remove();
    }
}
