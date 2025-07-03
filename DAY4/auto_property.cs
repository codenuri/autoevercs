class Point
{
    /*
    private int x;

    // 아래 프라퍼티는 어떠한 추가 코드 없이 그냥 set/get
    public int X
    {
        set { x = value; }
        get { return x; }
    }
    */
    // 아래 코드는 위와 동일.
    // auto implemented - property
    public int X { set; get; } = 0;

    public int x = 0;
}