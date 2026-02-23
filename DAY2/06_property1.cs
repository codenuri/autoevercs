// public field vs setter/getter

// Person1 : age 를 public 에 위치
class Person1
{
    public int age;
}

// Person2 : age 는 private 놓고 메소드로 접근
class Person2
{
    private int age;

    public int GetAge() => age;   // Getter

    public void SetAge(int value) // Setter
    {
        if (value > 0)
            age = value;
    }
}

class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
        Person2 p2 = new Person2();

        // #1. publie field
        // => 안전성이 부족하다
        // => 그런데, 가독성이 좋다
        p1.age = 10;
        int n1 = p1.age;

        p1.age = -10;


        // #2.setter/getter 사용
        // => 안전성이 높다
        // => 가독성이 1번 보다는 좋지 않다
        p2.SetAge(10);
        int n2 = p2.GetAge();

        p2.SetAge(-10);

        // 안전성도 높고, 가독성도 좋게 할수 없을까 ?
        // => property 문법
    }
}
