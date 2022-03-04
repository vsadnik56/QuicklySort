
public class Quick
{
    static int NumberS(int[] array, int MaxValues, int MinValues)
    {
        int index = MinValues - 1;
        int TimeValue;
        for (int i = MinValues; i < MaxValues; i++)
        {
            if (array[i] < array[MaxValues])
            {
                index++;
                TimeValue = array[index];
                array[index] = array[i];
                array[i] = TimeValue;
            }

        }
        index++;
        TimeValue = array[index];
        array[index] = array[MaxValues];
        array[MaxValues] = TimeValue;
        return index;
    }
    static int[] QuicklySort(int[] array, int MaxValues, int MinValues)
    {
        if (MaxValues < MinValues) return array;
        int MainIndex = NumberS(array, MaxValues, MinValues);
        QuicklySort(array, MaxValues, MainIndex + 1);
        QuicklySort(array, MainIndex - 1, MinValues);
        return array;
    }
    static void Main()
    {
        int[] array1 = { -1, 5, -4, 0, 12, 10 };
        Quick.QuicklySort(array1, array1.Length - 1, 0);
        foreach (int i in array1) Console.WriteLine(i);
    }
}