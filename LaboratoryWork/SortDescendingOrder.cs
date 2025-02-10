namespace LaboratoryWork;

public class SortDescendingOrder
{
    private int Swaps;
    private int[] Arr;

    public SortDescendingOrder(int[] arr, int ascendingSwaps)
    {
        Arr = arr;
        Swaps = ascendingSwaps;
    }
    
    public void Sort() 
    {
        int n = Arr.Length; 
        
        for (int i = 1; i < n; i++)
        {
            int j = i; 
            
            while (j > 0 && Arr[j - 1] < Arr[j]) // (j > 0 && Arr[j - 1] > Arr[j]) Только этим отличается от возврастания
            {
                
                int temp = Arr[j];
                Arr[j] = Arr[j - 1];
                Arr[j - 1] = temp;

                j--; 
                Swaps++; 
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