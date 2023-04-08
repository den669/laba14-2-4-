using System;
using System.Threading;

class Program
{
    static void Main()
    {
        
        string[] arr = { "c", "a", "b", "d", "f", "e" };

        
        Thread insertionSortThread = new Thread(() => InsertionSort(arr));
        Thread selectionSortThread = new Thread(() => SelectionSort(arr));
        Thread bubbleSortThread = new Thread(() => BubbleSort(arr));

        
        insertionSortThread.Start();
        selectionSortThread.Start();
        bubbleSortThread.Start();

        
        insertionSortThread.Join();
        selectionSortThread.Join();
        bubbleSortThread.Join();

        Console.WriteLine("Відсортований масив:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.ReadLine();
    }

    
    static void InsertionSort(string[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            string key = arr[i];
            int j = i - 1;

            while (j >= 0 && string.Compare(arr[j], key) > 0)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }

        Console.WriteLine("Сортування вставками завершено.");
    }

    
    static void SelectionSort(string[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (string.Compare(arr[j], arr[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            string temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        Console.WriteLine("Сортування вибором завершено.");
    }

    
    static void BubbleSort(string[] arr)
    {
        bool swapped;
        do
        {
            swapped = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (string.Compare(arr[i], arr[i + 1]) > 0)
                {
                    string temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }

        } while (swapped);

        Console.WriteLine("Сортування бульашкою завершено.");
    }
}
