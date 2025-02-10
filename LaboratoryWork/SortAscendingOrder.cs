namespace LaboratoryWork;

public class SortAscendingOrder : DataOutput
{
    private int Swaps;
    private int[] Arr;

    public SortAscendingOrder(int[] arr, int ascendingSwaps)
    {
        Arr = arr;
        Swaps = ascendingSwaps;
    }
    
    public void Sort()
    {
        int n = Arr.Length;

        // Проходим по массиву, начиная со второго элемента, начинается подсчет с 0 
        for (int i = 1; i < n; i++)
        {
            int j = i; // Начинаем с текущего элемента
            // Пока не дошли до начала массива и предыдущий элемент больше текущего
            while (j > 0 && Arr[j - 1] > Arr[j])
            {
                // Меняем местами элементы arr[j] и arr[j-1]
                int temp = Arr[j];
                Arr[j] = Arr[j - 1];
                Arr[j - 1] = temp;

                j--; // Переходим к предыдущему элементу
                Swaps++;  // Увеличиваем число перестановок
            }
        }
    }

    public int[] OutputAscendingArray()
    {
        return Arr;
    } 
    
    public int OutputSwaps()
    {
        return Swaps;
    } 

}