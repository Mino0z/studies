using System;

class BinarySearchExample
{
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid; 
            }

            if (array[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                
                left = mid + 1;
            }
        }

        return -1; 
    }

    public static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 7;

        int result = BinarySearch(array, target);
        if (result != -1)
        {
            Console.WriteLine($"Element {target} znaleziony na indeksie {result}");
        }
        else
        {
            Console.WriteLine($"Element {target} nie został znaleziony.");
        }
    }
}
