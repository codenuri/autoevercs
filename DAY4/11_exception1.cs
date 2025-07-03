using static System.Console;

// 예외 개념

// 모든 함수는 실패 할수 있습니다.
// 실패시 호출자에게 보고해야 합니다.

// C 언어 : 반환 값으로 실패를 알려 줍니다.

// 단점 : 함수가 실패 했다고 알리는 것을 호출자가 무시 할수도 있다.
// => 에러 처리의 강제성이 없다.
// => 심각한 오류를 무시하고 계속 실행되면 더 큰 문제가 발생할수 있다.


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

        bool ret = db.Backup();    

        /*
        // 사용자가 오류 처리를 안했다!!
        if ( ret == false )
        {
            // 오류 처리.!!
        }
        */

        db.Remove();
    }
}
