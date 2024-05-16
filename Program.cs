namespace Sorting;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = [31, 24, 43, 82, 33, 4, 66, 7, 1, 2, 77];
        int[] sortedNums = QuickSort.QkSort(nums);
        Console.WriteLine("QuickSort ");

        foreach (int num in sortedNums)
        {
            Console.Write($" {num} ");
        }

        List<int> nums2 = [43, 32, 12, 45, 22, 73, 555, 34, 14, 89 ];
        List<int> sortedNums2 = MergeSort.MrgSort(nums2);

        Console.WriteLine("\nMergeSort");
        foreach (int num2 in sortedNums2)
        {
            Console.Write($" {num2} ");
        }

        List<double> nums3 = [1.2, 34.5, 0.9, -8.4, 3.2, -0.3, 0.3];
        List<double> sortedNums3 = MergeSort.MrgSort(nums3);

        Console.WriteLine("\nMergeSort Doubles");
        foreach (double num in sortedNums3)
        {
            Console.Write($" {num} ");
        }

        List<int> nums4 = [43, 32, 12, 45, 22, 73, 555, 34, 14, 89 ];
        List<int> sortedNums4 = SelectionSort.SelctSort(nums4);
        
        
        Console.WriteLine("\nSelectionSort");
        foreach (double num in sortedNums4)
        {
            Console.Write($" {num} ");
        }
    }
}
