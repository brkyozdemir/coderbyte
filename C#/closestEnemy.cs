int[] arr = {1, 2, 2, 2, 0, 0,0,0,0,0,0,0,0,0,0,0, 2, 0};
int i, j;
int min_dist = int.MaxValue;
for (i = 0; i < arr.Length; i++)
  {
    for (j = 0; j< arr.Length; j++)
      {
        if((arr[i]==1 && arr[j]==2 || arr[j]==1 && arr[i]==2) && min_dist > Math.Abs(i - j))
          {
            min_dist = Math.Abs(i - j);
          }
      }
   }

Console.WriteLine(min_dist);
Console.ReadKey();
