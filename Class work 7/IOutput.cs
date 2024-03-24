using System;

// Інтерфейс IOutput
public interface IOutput
{
    void Show();
    void Show(string info);
}

public class Array : IOutput
{
    private int[] data;

    public Array(int[] array)
    {
        data = array;
    }

    public void Show()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (int item in data)
        {
            Console.WriteLine(item);
        }
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }

}



class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Array array = new Array(arr);
        array.Show();
        array.Show("Це масив чисел:");

        Console.WriteLine();

        int[] arr1 = { 1, 3, 5, 7, 9 };
        MathArray mathArray = new MathArray(arr1);

        Console.WriteLine("Max: " + mathArray.Max());
        Console.WriteLine("Min: " + mathArray.Min());
        Console.WriteLine("Avg: " + mathArray.Avg());
        Console.WriteLine("Find num 5: " + mathArray.Search(5));
        Console.WriteLine("Find num 10: " + mathArray.Search(10));

        Console.ReadLine();
    }
}