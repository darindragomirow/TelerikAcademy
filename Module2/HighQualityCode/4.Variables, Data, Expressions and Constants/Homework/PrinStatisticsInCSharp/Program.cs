using System;

public class MyClass
{
    public void PrintStatistics(double[] arr, int count)
    {
        double max=double.MinValue,
               sum=0;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        PrintNum(max);
        
       double min=double.MaxValue;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] < min)
            {
               min = arr[i];
            }
        }
        PrintNum(min);
;
        for (int i = 0; i < count; i++)
        {
           sum += arr[i];
        }
        PrintNum(sum / count);
    }

    private void PrintNum(double num)
    {
        Console.WriteLine("{0:F2}",num);
    }
    
}