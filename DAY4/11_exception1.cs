using static System.Console;

// ���� ����

// ��� �Լ��� ���� �Ҽ� �ֽ��ϴ�.
// ���н� ȣ���ڿ��� �����ؾ� �մϴ�.

// C ��� : ��ȯ ������ ���и� �˷� �ݴϴ�.

class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        return false; // �����ߴٰ� ����..

        // return true; // �����ߴٸ� true ��ȯ
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
