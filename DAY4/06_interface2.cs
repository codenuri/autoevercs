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













class Camera
{
    public void Take() { WriteLine("take picture"); }
}

class HDCamera
{
    public void Take() { WriteLine("take HD picture"); }
}

class Person
{
    public void UseCamera(Camera c) { c.Take(); }
    public void UseCamera(HDCamera c) { c.Take(); }
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

