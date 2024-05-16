namespace Sorting;

public static class QuickSort 
{
  public static T[] QkSort<T>(T[] array, int low = 0, int high = -1) where T : IComparable
  {
    if (high == -1)
    {
      high = array.Length - 1;
    }
    if (low < high)
    {
      int piv_idx = Partition(array, low, high);
      QkSort(array, low, piv_idx - 1);
      QkSort(array, piv_idx + 1, high);
    }
    return array;
  }

  public static int Partition<T>(T[] array, int low, int high) where T : IComparable
  {
    T pivot = array[high];
    int i = low - 1;
    for (int j = low; j < high; j++)
    {
      if (array[j].CompareTo(pivot) <= 0)
      {
        i += 1;
        T temp = array[j];
        array[j] = array[i];
        array[i] = temp;
      }
    }
    (array[i + 1], array[high]) = (array[high], array[i + 1]);
    return i + 1;
  }
}