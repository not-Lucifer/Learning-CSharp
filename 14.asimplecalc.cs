Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("**************************************************");
Console.WriteLine("*                                                *");
Console.WriteLine("*   ███████╗██╗███╗   ███╗██████╗ ██╗     ███████╗*");
Console.WriteLine("*   ██╔════╝██║████╗ ████║██╔══██╗██║     ██╔════╝*");
Console.WriteLine("*   ███████╗██║██╔████╔██║██████╔╝██║     █████╗  *");
Console.WriteLine("*   ╚════██║██║██║╚██╔╝██║██╔═══╝ ██║     ██╔══╝  *");
Console.WriteLine("*   ███████║██║██║ ╚═╝ ██║██║     ███████╗███████╗*");
Console.WriteLine("*   ╚══════╝╚═╝╚═╝     ╚═╝╚═╝     ╚══════╝╚══════╝*");
Console.WriteLine("*                                                *");
Console.WriteLine("*        ██████╗ █████╗ ██╗      ██████╗          *");
Console.WriteLine("*       ██╔════╝██╔══██╗██║     ██╔════╝          *");
Console.WriteLine("*       ██║     ███████║██║     ██║               *");
Console.WriteLine("*       ██║     ██╔══██║██║     ██║               *");
Console.WriteLine("*       ╚██████╗██║  ██║███████╗╚██████╗          *");
Console.WriteLine("*        ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝          *");
Console.WriteLine("*                                                *");
Console.WriteLine("**************************************************");

Console.ResetColor();

Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Operator:");
char op = Convert.ToChar(Console.ReadLine());
int answer;
switch (op)
{
    default: 
        Console.WriteLine("Invalid Operator");
        break;
    case '+': 
        answer = sum(num1,num2);
        break;
    case '-':
        answer = subtract(num1,num2);
        break;
    case '*':
        answer = multiply(num1,num2);
        break;
    case '/':
        answer = divide(num1,num2);
        break;     

}
Console.WriteLine("Answer:"+answer);

int sum(int _num1 , int _num2)
{
    return _num1+_num2;
}
int subtract(int _num1, int _num2)
{
    return _num1-_num2;
}
int multiply( int _num1, int _num2)
{
    return _num1*_num2;
}
int divide(int _num1,int _num2)
{
    return _num1/_num2;
}
