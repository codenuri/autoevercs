// 핵심 #1. property 만들고 사용하는 방법 알아 두세요
// => 메소드와 필드의 특징이 적절이 섞여 있습니다.

// #2. 사용자 입장은 필드 처럼 보이지만
//     구현은 메소드 형태 입니다.
//     => 제어문 사용해서 값 유효성 조사 가능

// #3. 원리!!!
// => Property 를 컴파일 하면
// => set_Age(), get_Age() 함수를 생성하게 됩니다.
// => 결국 setter/getter 만드는 것과 동일

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

    // 아래 처럼 사용자가 만들때
    // => property 가 생성한 setter 와 이름이 충돌되어서
    // => 에러입니다. 아래 부분 또는 위 set{} 부분에서 에러
    public void set_Age(int value)
    {

    }
}
class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10;    // 컴파일 되면 p1.set_Age(10)
        int n = p1.Age; // int n = p1.get_Age()
                        // 로 변경된것    
    }
}
