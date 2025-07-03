using System.Diagnostics;
using static System.Console;

// 실패시 그냥 함수 안에서 종료한다면..
// => 호출자에 에러에 대한 처리를 할 기회가 없다!!!

class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        // 심각한 오류를 보고 하지 않고 여기서 프로세스 종료
//      Process.Exit(-1); 

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
