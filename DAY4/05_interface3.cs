using static System.Console;

// 아래 코드는 새로운 카메라(HDCamera) 가 추가될때
// => Person 의 코드가 수정되었습니다
// => OCP 를 만족하지 못하는 확장성 없는 설계 입니다

class Camera
{
    public void Take() { WriteLine("take picture");  }
}

class HDCamera
{
    public void Take() { WriteLine("take HD picture"); }
}

class Person
{
    public void UseCamera(Camera c) {  c.Take(); }
    public void UseCamera(HDCamera c) { c.Take(); }
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

