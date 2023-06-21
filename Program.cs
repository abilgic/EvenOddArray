int[] arr = { 1, 2, 5, 8, 12, 21, 4 };

for (int j = 0; j < arr.Length; j++)
{
    for (int i = 0; i + 1 < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            var temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }
    }

}


foreach (var item in arr)
    Console.Write($"{item}, ");

