// 155 page

// class List<T> where T : 인터페이스 이름  => 인터페이스를 구현해야 한다.
// class List<T> where T : struct          => value type 이어야 한다.
// class List<T> where T : class           => reference type 이어야 한다.
// class List<T> where T : new()           => 인자 없는 생성자 있어야 한다.
//						// 그외에, C# 버전 마다 다릅니다.
//						// MS 도움말 참고
//						// 구글, C# generic constraint 검색



class List<T> where T : struct    // T 는 value type 이어야 한다.
{	
}

class Program 
{
	public static void Main()
	{
		List<int>    c1 = new List<int>();		// ok
		List<string> c2 = new List<string>();	// error

		Nullable<int> n = null;
	}	
}









/*
class C1<T> where T : struct           {} // value
class C2<T> where T : class            {} // reference
class C3<T> where T : class?           {} // null 가능
class C4<T> where T : notnull          {} // null 불가능 타입
class C5<T> where T : unmanaged        {}

class C6<T> where T : new()        // 디폴트 생성자(인자없는 생성자)
{
	public void Foo()
	{
		T a = new T(); // 제약이 없으면 안됨
	}

}


// class C7<T> where T : base_class_name  {}
// class C8<T> where T : base_class_name? {}
// class C9<T> where T : interface_name   {}
// class C10<T> where T : interface_name?  {}


class C11<T> where T : class, IComparable<T>
{ 
}

class C12<T, U> where T : struct  
			    where U : class
{ 
}
*/