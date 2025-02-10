using System;
using LaboratoryWork;

public class InsertionSort 
{
    public static void Main(string[] args)
    {
        int[] originalArray = { 10, 8, 3, 28, 11, 4, 1 }; // Исходный массив

        // Сортировка по возрастанию
        int ascendingSwaps = 0; // Переменная для числа перестановок
        SortAscendingOrder SortingA = new SortAscendingOrder(originalArray, ascendingSwaps); // Вызываем метод сортировки по возрастанию, получаем число перестановок

        SortingA.Sort();
        int[] sortedArrayA = SortingA.OutputAscendingArray();
        int swapsA = SortingA.OutputSwaps();
        Console.WriteLine($"Массив, отсортированный по возрастанию:{ sortedArrayA }"); 
        Console.WriteLine($"Число перестановок (по возрастанию): { swapsA } "); 

        // Сортировка по убыванию

        SortDescendingOrder SortingD = new SortDescendingOrder(originalArray, ascendingSwaps);
        
        SortingD.Sort();
        int[] sortedArrayD = SortingD.OutputAscendingArray();
        int swapsD = SortingD.OutputSwaps();

        Console.WriteLine($"Массив, отсортированный по убыванию:{ sortedArrayD }"); 
        Console.WriteLine($"Число перестановок (по убыванию): { swapsD } ");
    }
}