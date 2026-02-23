// inheritance (상속 )

// 모든 사람의 특징을 뽑아서 Person 타입을 설계
class Person
{
    private string name;
    private int age;

    private string email; // 여기에 추가 하면
                          // Person 의 파생 클래스에 모두 추가됨
}

// Person  : Base class,    Super class, Parent class 라는 용어 사용
// Student : Derived class, Sub class,   Child class 

// 상속(inheritance)
// => 기존 타입을 확장해서 새로운 타입을 만드는 것
// => class 만 가능. struct 는 상속 문법 사용 못함

class Professor : Person
{
    private string major;
}

class Student : Person
{
    private string id;
}

class Program
{
    public static void Main()
    {
        Student s = new Student();

    }
}
