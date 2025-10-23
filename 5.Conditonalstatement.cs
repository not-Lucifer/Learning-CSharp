int a = 34;
if (a == 34)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
//**************If-Else If Ladder*********************
int i = Console.Read();
int b = Console.Read();
if (i % 3 == 0)
{
    Console.WriteLine("Divisible by 3");
}
else if (i % 3 == 1)
{
    Console.WriteLine("Remainder = 1");
}
else
{
    Console.WriteLine("Remainder = 2");
}
//*****************SWITCH****************************
switch (b){
    default:
        Console.WriteLine("Not in range");
        break;   
    case 1:
        Console.WriteLine('1');
        break;
    case 2:
        Console.WriteLine('2');
        break;
    case 3:
        Console.WriteLine('3');
        break;
}
