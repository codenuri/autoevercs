// csc 컴파일러를 사용해서 컴파일 하면
// => 소스이름.exe 로 생성됩니다.

// visual studio 사용시
// => 프로젝트이름.dll 로 생성됩니다.
// => exe로 만들려면 추가 작업 필요

// "프로젝트이름.dll" 안에 있는 코드가 중간언어(CIL)입니다.

class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (age > 0 && age < 150)
                age = value;
        }
    }
}
class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10;    
        int n = p1.Age; 
    }
}
