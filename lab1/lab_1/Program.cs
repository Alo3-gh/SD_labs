// Чтение входного числа N из файла

using System;
using System.IO;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(File.ReadAllText("input.txt"));

        bool isFound = false;

        for (long q = 2; q <= Math.Sqrt(N) + 1; q++)
        {
            if (N % q == 0)
            {
                long A = N / q;

                // Запись найденных значений A и B в выходной файл
                if (!File.Exists("output.txt"))
                {
                    File.Create("output.txt");
                }

                File.WriteAllText("output.txt", $"Чуб Кирилл Олегович\n090301-ПОВа-з21\n{A} {N - A}");
                isFound = true;

                break;
            }
        }

        if (!isFound)
        {
            // Запись найденных значений A и B в выходной файл
            File.WriteAllText("output.txt", $"Чуб Кирилл Олегович\n090301-ПОВа-з21\n1 {N - 1}");
        }
    }
}