namespace Sorting;

public static class SelectionSort
{
  public static List<T> SelctSort<T>(List<T> lst) where T : IComparable
  {
    int idx = 0;
    
    while (idx < lst.Count)
    {
      int minIdx = idx;
      T minV = lst[idx];
      for (int i = idx; i < lst.Count; i++)
      {
        if (lst[i].CompareTo(minV) < 0)
        {
          minIdx = i;
          minV = lst[i];
        }
      }
      T tmp = lst[idx];
      lst[idx] = minV;
      lst[minIdx] = tmp;
      idx++;
    }

    return lst;
  }
}