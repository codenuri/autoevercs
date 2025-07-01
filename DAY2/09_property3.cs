// 핵심 #1. property 만들고 사용하는 방법 알아 두세요
// => 메소드와 필드의 특징이 적절이 섞여 있습니다.

// #2. 사용자 입장은 필드 처럼 보이지만
//     구현은 메소드 형태 입니다.
//     => 제어문 사용해서 값 유효성 조사 가능

// #3. 원리!!!


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
