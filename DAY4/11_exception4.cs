using System.Diagnostics;
using static System.Console;


class DBBackupException : Exception
{
    // 다양한 멤버를 사용해서 실패 이유를 담을수 있게 하세요
    private string message;

    public DBBackupException(string s) => message = s;
}


class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        // if(실패시)
        throw new DBBackupException("접근권한없음");

        return true;
    }
    public void Remove() => WriteLine("Remove DB");
}



class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        // #1. 예외 가능성이 있는 코드를 사용할때는
        //     try block 안에서 해야 합니다.

        try
        {
            bool ret = db.Backup();

            // 위 코드에서 예외가 나오면 아래 줄로 갈수 없고, catch 로 이동

            // .... 다른 작업
            
        }
        catch (DBBackupException ex)
        {
            WriteLine("예외 발생");

            // 여기서 발생된 예외에 대해 해결할수 없다면
            // 사용자에게 알리고 프로그램 종료 하세요
            Process.GetCurrentProcess().Kill();

            // 만일 여기서 종료 안하면 프로그램 계속 실행 됩니다.
        }

        WriteLine("프로그램 계속 실행");
        db.Remove();
    }
}

// 함수 실패에 대한 대표적인 코드
// 1. C 방식 - 함수 반환값으로
// 2. 객체지향 - 예외
// 3. Rust 언어가 완전히 다른 방식 제안 - 학습해 보세요
