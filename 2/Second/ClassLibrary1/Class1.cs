using System.IO;
using System.Threading;

namespace Second
{
    public class SaveAsThread
    {
        public static void SaveArrayToFile(int[] array, string fileName)
        {
            // Запис масиву у файл у паралельному потоці
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (int num in array)
                {
                    writer.WriteLine(num);
                    Thread.Sleep(100); // Затримка для демонстрації паралельної роботи потоків
                }
            }
        }
    }
}
