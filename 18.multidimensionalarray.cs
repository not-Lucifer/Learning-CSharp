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

//2D Jagged array(array of array)

int[][] array3 = new int[3][];
array3[0]= new int[3];
array3[1]= new int[3];
array3[2]= new int[3];
array3[0][0] = 1;
array3[0][1] = 1;
array3[0][2] = 1;
array3[1][0] = 1;
array3[1][1] = 1;
array3[1][2] = 1;
array3[2][0] = 1;
array3[2][1] = 1;
array3[2][2] = 1;
Console.WriteLine();

for(int i = 0; i < array3.Length; i++)
{
    for(int j = 0; j < array3[0].Length; j++)
    {
        Console.Write(array3[i][j]+" ");
    }
    Console.WriteLine();
}