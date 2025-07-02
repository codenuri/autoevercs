// inheritance (상속 )
// 사람의 공통의 특징을 별도의 타입으로 설계
class Person
{
    private string name;
    private int age;
}

// 상속(inheritance)
// => 기존 타입을 확장해서 새로운 타입을 만드는 문법
// => 다양한 객체 지향언어가 지원하고 동일한 개념인데, 표기법만 차이가 있습니다
// C#     : class Professor : Person
// C++    : class Professor : public Person
// Python : class Professor (Person)
// Java   : class Professor extends Person

// 용어
// Person  : Base(기반) class,    Super class,    Parent class
// Student : Derived(파생) class, Sub class,      Child class


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
