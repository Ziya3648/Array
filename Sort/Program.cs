
int[] arr = { 0, 50, -11, 23, 18 };

    int min = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                min = arr[i];
                arr[i] = arr[j];
                arr[j] = min;
            }

        }
        Console.WriteLine(arr[i]);

    }






