int[] x = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


// for : 갯수가 명확한 경우에 사용
for (int i = 0; i < 10; i++) 
{
    WriteLine($"{x[i]}");
}

// foreach : 배열이나 컬렉션의 모든 요소 열거 - python 의 for
// python : for e in x
foreach( int e in x )  
{
    WriteLine($"{e}");
}