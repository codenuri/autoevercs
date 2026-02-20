using static System.Console;

// 핵심 : for 문

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};


// C# for : C/C++ 언어와 동일. 파이썬과 다름
for( int i = 0; i < 10; i++)
{
    WriteLine($"{x[i]}");
}