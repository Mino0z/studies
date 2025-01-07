using System;

class Program{
    static void Main(){
        int[] arr = {42, 32, 12, 52, 62, 82, 95, 45, 75, 85};
        mergeSort(arr);
        foreach(int i in arr){
            Console.Write(i + " ");
        }
    }
    public static void mergeSort( int[] arr){
        int length = arr.Length;
        if(length <=1) return;
        int mid = length/2;
        int[] left = new int[mid];
        int[] right = new int[length-mid];
        int i =0 ;
        int j = 0;
        for(; i<length; i++){
            if(i<mid){
                left[i] = arr[i];
            }else{
                right[j] = arr[i];
                j++;
            }
        }
        mergeSort(left);
        mergeSort(right);
        merge(left, right, arr);
    }
    public static void merge( int[] left, int[] right, int[] arr){
        int leftLength = left.Length;
        int rightLength = right.Length;
        int i = 0, l = 0, r = 0;
        while(l<leftLength && r<rightLength){
            if(left[l] < right[r]){
                arr[i] = left[l];
                l++;
                i++;
            }else{
                arr[i] = right[r];
                r++;
                i++;
            }
            
        }
        while(l<leftLength){
            arr[i] = left[l];
            l++;
            i++;
        }
        while(r<rightLength){
            arr[i] = right[r];
            r++;
            i++;
        }
    }
}