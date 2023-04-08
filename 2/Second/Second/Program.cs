using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8, 9, 10 };
            int[] array3 = { 11, 12, 13, 14, 15 };

            
            Task.Run(() => SaveAsThread.SaveArrayToFile(array1, "array1.txt"));
            Task.Run(() => SaveAsThread.SaveArrayToFile(array2, "array2.txt"));
            Task.Run(() => SaveAsThread.SaveArrayToFile(array3, "array3.txt"));

            Console.WriteLine("Масиви записані у файли у паралельних потоках.");
            Console.ReadLine();
        }
    }
}
