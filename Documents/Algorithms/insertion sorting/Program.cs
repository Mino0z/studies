using System;

class Program {
    static void Main() {
        int[] arr = { 12, 11, 13, 5, 6 };
        InsertionSort(arr);
        
    }
    public static void InsertionSort(int[] arr) {
        for(int i = 1; i < arr.Length; i++) {
            int temp = arr[i];
            int j = i - 1;
            while(j >= 0 && arr[j] > temp) {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
        }
        for(int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
    }
}