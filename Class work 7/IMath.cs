using System;

// Інтерфейс IMath
public interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

public class MathArray : IMath
{
    private int[] data;

    public MathArray(int[] array)
    {
        data = array;
    }

    public int Max()
    {
        int max = data[0];
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }
        }
        return max;
    }

    public int Min()
    {
        int min = data[0];
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] < min)
            {
                min = data[i];
            }
        }
        return min;
    }

    public float Avg()
    {
        int sum = 0;
        foreach (int num in data)
        {
            sum += num;
        }
        return (float)sum / data.Length;
    }

    public bool Search(int valueToSearch)
    {
        foreach (int num in data)
        {
            if (num == valueToSearch)
            {
                return true;
            }
        }
        return false;
    }
}