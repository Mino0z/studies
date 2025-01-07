using System;

class Program{
    static void Main(){
        int[] arr = {99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0};
        SelectionSort(arr);
        foreach(int i in arr){
            Console.Write(i + " ");
        }
    }   
    public static void SelectionSort(int[] arr){
        for(int i = 0; i < arr.Length; i++){
            int minIndex = i;
            for(int j = i+1; j < arr.Length; j++){
                if(arr[j] < arr[minIndex]){
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }

}