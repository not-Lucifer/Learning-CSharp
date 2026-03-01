//2D ARRAY
int[,] intarray = new int[5,6];
intarray[0,2]=6;
Console.WriteLine(intarray[0,2]);

int[,] array2 = new int[,] {{1,2,3},{4,5,6}};
for(int i = 0 ; i < array2.GetLength(0);i++)
{
    for(int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array2[i,j]+" ");
    }
    Console.WriteLine();
}