using static System.Console;

// 노트북과 USB 메모리
// => 미래에 나오는 USB 메모리라도 현재 노트북에 연결가능합니다.
// => OCP 를 만족합니다.
// => 원리는 "노트북과 USB 메모리" 가 지켜야 하는 규칙이 있고 규칙대로 사용하므로

// 카메라는 무조건 만들지 말고,
// 모든 카메라 제품이 지켜야 하는 규칙을 먼저 설계
// => 인터페이스 라고 합니다.

interface ICamera
{
    // 모든 카메라가 만들어야 하는 메소드 이름을 약속 - 구현없이 이름만
    // 접근지정자를 표기하지 않습니다.
    void Take(); 
}

// 진짜 카메라가 없어도 규칙이 있다면 
// 사용하는 코드를 만들수 있습니다
// => 규칙대로만 사용하면 됩니다.
class Person
{
    // 핵심 : 구체적인 제품의 이름이 아닌 "규칙"의 이름으로 사용
    public void UseCamera(ICamera c) { c.Take(); }
}

// 모든 카메라 제품은 규칙을 지켜야 합니다.
// => ICamera 를 구현하겠다고 표기하고(상속과 동일한 표기법)
// => Take() 메소드 구현

class Camera : ICamera
{
    public void Take() { WriteLine("take picture"); }
}

class HDCamera : ICamera
{
    public void Take() { WriteLine("take HD picture"); }
}
class UHDCamera : ICamera
{
    public void Take() { WriteLine("take UHD picture"); }
}


class Program
{
    public static void Main()
    {
        Person p = new Person();
        Camera c = new Camera();

        p.UseCamera(c);

        HDCamera h = new HDCamera();
        p.UseCamera(h); // ok

        UHDCamera u = new UHDCamera();
        p.UseCamera(u); // ok. Person 을 수정하지 않고도 사용가능
                        // OCP 만족
    }
}

// 추상 클래스 vs 인터페이스
// 추상 클래스 : 지켜야 하는 규칙(추상메소드) + 다른 멤버도 있는 경우 => Shape
// 인터 페이스 : 지켜야 하는 규칙 만 있는 것

// C++      : 추상 클래스 문법만 제공. 인터페이스 개념도 추상 클래스 문법으로구현
// C#, Java : 완벽히 분리!. 별도 키워드제공
//            abstract class 인데, 추상 메소드만으로 구현해도 인터페이스와유사

// 표현 : "모든 카메라는 ICamera 로 부터 상속 받아야 한다" 가 아니라
//        "모든 카메라는 ICamera 를 구현해야 한다" 라고 표현
// => 표기법만 상속과 동일. 

// 용어 정리
// 강한 결합(tightly coupling )
// => 하나의 클래스가 다른 클래스 사용시 클래스 이름을 직접 사용하는 것
// => Person::UseCamera(Camera) <<=== Camera 이름을 직접 사용
// => 확장성없는 경직된 디자인. 

// 약한 결합(loosely coupling )
// => 하나의 클래스가 다른 클래스 사용시 클래스 이름을 직접 사용하지 말고
//    규칙을 담은 인터페이스 이름을 사용하는 것
// => Person::UseCamera(ICamera) <<=== ICamera 라는 규칙(인터페이스)이름
// => 확장성있고 유연한 디자인. 

// C#, Java 는 "모든 것이 인터페이스" 일 정도로 널리 사용