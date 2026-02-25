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



class Program
{
    public static void Main()
    {
        Person p = new Person();
        Camera c = new Camera();

        p.UseCamera(c);

        HDCamera h = new HDCamera();
        p.UseCamera(h); // ?
    }
}

