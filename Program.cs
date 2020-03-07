using System;

namespace ASP_bubble_sort
{
    class Program
    {// An optimized version of Bubble Sort 
    static void bubbleSort(int []arr) 
    { 
        int i, j, temp; 
        int n = arr.Length;
        bool swapped; 
        for (i = 0; i < n - 1; i++)  
        { 
            swapped = false; 
            for (j = 0; j < n - i - 1; j++)  
            { 
                if (arr[j] > arr[j + 1])  
                { 
                    // swap arr[j] and arr[j+1] 
                    temp = arr[j]; 
                    arr[j] = arr[j + 1]; 
                    arr[j + 1] = temp; 
                    swapped = true; 
                } 
            } 
  
            // IF no two elements were  
            // swapped by inner loop, then break 
            if (swapped == false) 
                break; 
        } 
    } 
  
    // Function to print an array  
    static void printArray(int []arr) 
    { 
        int i; 
        for (i = 0; i < arr.Length; i++) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
    } 
  
    // Driver method  
    public static void Main() 
    { 
        int []arr = {640, 364, 250, -12, 282, 131, -90}; 
        bubbleSort(arr); 
        Console.WriteLine("Sorted array"); 
        printArray(arr); 
    } 
    }
}
