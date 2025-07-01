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
