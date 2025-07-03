using static System.Console;



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
