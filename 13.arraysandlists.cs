//************DECLARATION OF ARRAYS**************
int[] arr1 = {1,2,3};
int[] arr2 = new int[] {1,2,3};
int[] arr3 = new int[5]; // array of size 5
Console.WriteLine(arr1.Length);


//**************DECLARATION OF LISTS**************

List<int> ls1 = new List<int>(); //no fixed size - can grow or shrink
ls1.Add(91);
Console.WriteLine(ls1.Count);
Console.WriteLine(ls1[0]);
