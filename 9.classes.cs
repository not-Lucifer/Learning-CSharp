using System;

Myclass myobject = new();
class Myclass
{
    float myfloat = 10.56F;
    int myint = 23;
    public Myclass()
    {
        TestFunction();
    }
    void TestFunction()
    {
        Console.WriteLine(myfloat);
        Console.WriteLine(myint);
    }
}