using static System.Console;


// 카메라를 먼저 만들지 말고,
// 카메라와 카메라 사용자 사이에 지켜야하는 규칙을 먼저 설계 한다.

// 규칙 : 모든 카메라는 아래 인터페이스로 부터 파생되어야 한다

interface ICamera
{
    void Take();
}

// 이제 규칙이 있으므로 구체적인 카메라 제품이 없어도
// 사용하는 코드를 먼저 만들수 있습니다.
// 규칙 대로만 사용하면 됩니다.

class Person
{
    public void UseCamera(ICamera c) { c.Take(); }
}

// 이제 모든 카메라 제조사는 규칙을 지켜야 합니다.
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


        HDCamera hc = new HDCamera();

        p.UseCamera(hc); // ???

    }
}

