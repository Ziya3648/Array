


int[] arr = { 0, 50, -11, 23, 18 };
int MinValue(int[] arr)
{
    int index = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
          //  min = arr[i];
            index = i;
        }
    }
    return index;
    //return min;

}



Console.WriteLine(MinValue(arr));
