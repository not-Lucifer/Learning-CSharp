using System;
using System.Security.Cryptography.X509Certificates;
List<int> intlist = new List<int>() {1,2,3};

foreach (int i in intlist)
{
    Console.WriteLine(i);
}

for (int j = 0; j < intlist.Count; j++)
{
    Console.WriteLine(j + " " + intlist[j]);
}

int l =0;
while (l < 5)
{
    Console.WriteLine(l);
    l++;
}
int x = 0;
do
{
    Console.WriteLine(x);
    x++;
} while (x < 0);
