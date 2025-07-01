// Property 의 핵심
// 1. Getter/Setter 를 편리하게 만드는 문법
// 2. 사용자는 Getter/Setter 를 사용하게 되는것이지만
//    마치 필드처럼 보이게 된다.

// => 사용자는 필드 처럼 사용하고
// => 구현은 "메소드 처럼" 구현

// 약속된 형태를 외워야 합니다.
// 소문자로 시작해도 되지만, 코딩 관례는 대문자

// C# 관례
// 클래스이름 첫글자, 메소드 이름 첫글자, 프라퍼티이름 첫글자 : 대문자
// 필드이름 : 소문자. 

class Person
{
    private int age;
    
    // 아래 Age 는 ()가 없으므로 "필드" 처럼 보입니다.
    // 그런데, {} 가 있으므로 "메소드" 처럼 보입니다.
    public int Age
    {
        get { return age; }
        set 
        { 
            if( age > 0 && age < 150)
                age = value; 
        }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10; // 쓰는 작업이므로 Age Property 의
                     // set 부분이 호출됩니다.
                     // 10 은 약속된 이름인 value 로 전달

        int n = p1.Age; // 읽는 작업 이므로 Age Property 의 
                        // get 부분이 호출됩니다.
    }
}
