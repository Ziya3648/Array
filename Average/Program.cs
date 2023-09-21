

int[] arr = { 0, 50, -11, 23, 18 };
int Average(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i]; 
    }
    return sum/arr.Length;
}

Console.WriteLine(Average(arr));
