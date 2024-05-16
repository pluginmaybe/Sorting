namespace Sorting;

public static class MergeSort
{
  public static List<T> MrgSort<T>(List<T> arr) where T : IComparable
  {
    if (arr.Count <= 1) return arr;
    int mid = arr.Count / 2;
    List<T> left = arr[0..mid];
    List<T> right = arr[mid..];

    List<T> sortLeft = MrgSort(left);
    List<T> sortRight = MrgSort(right);

    return Merge(sortLeft, sortRight);
  }

  public static List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable
  {
    List<T> result = [];
    int i = 0;
    int j = 0;

    while(i < left.Count || j < right.Count)
    {
      if (i == left.Count)
      {
        result.Add(right[j]);
        j++;
        continue;
      }
      if (j == right.Count)
      {
        result.Add(left[i]);
        i++;
        continue;
      }
      if (left[i].CompareTo(right[j]) < 0)
      {
        result.Add(left[i]);
        i++;
      } else
      {
        result.Add(right[j]);
        j++;
      }
    }
    return result;
  }
}