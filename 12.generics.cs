using System;
private T[] createarray<T>(T a, T b)
{
    return new T[] { a, b };
}
int[] Array = createarray<int>(1, 2);
string[] stringarray = createarray<string>("asfhk", "dhakaf");
Console.WriteLine(Array[0]);
Console.Write(stringarray[0]);
