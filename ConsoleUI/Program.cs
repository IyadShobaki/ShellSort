using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // In-place algorithm
            // Tim complexity is depend on the gap. Worst case is O(n^2), but 
            // it can perform much better than that
            // Unstable algorithm

            // Shell sort is a way of improving Insertion sort
            // We will use simple way to calculate the gap but the Knuth Sequence is 
            // commonly used sequence to calculate the gap 
            /*
             Using Knuth Sequence to calculate the gap =  (3^k - 1) / 2
             k value is based on the length of the array
             For example ( k value = 1 ---> Gap(interval) = 1)
                         (k  value = 2--->  Gap(interval) = 4)
                         (k  value = 3--->  Gap(interval) = 13)
                         (k  value = 4--->  Gap(interval) = 40)
                         (k  value = 5--->  Gap(interval) = 121)
             so if we have an array with 20 elements we need k to be 3, so the gap will be 13
             less than the array length
            */
            // The calculation of the gap the course teach is (array.length /2)
            // In the end the gap will be 1 and then the sorting will be regualr insertion sort
            // but it will reduce the amount of elements that need to be sorted
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            // first iteration gap = 3. Second iteration will be 3/2 = 1
            for (int gap = intArray.Length / 2; gap > 0; gap /= 2) 
            {
                for (int i = gap; i < intArray.Length; i++)
                {
                    int newElement = intArray[i];

                    int j = i;

                    while (j >= gap && intArray[j-gap] > newElement)
                    {
                        intArray[j] = intArray[j - gap];
                        j -= gap;
                    }
                    intArray[j] = newElement;
                }
            }



            //for (int gap = intArray.Length / 2; gap > 0; gap /= 2) 
            //{
            //    for (int i = gap; i < intArray.Length; i++)
            //    {
            //        int newElement = intArray[i];

            //        int j = i;
            //        while (j >= gap && intArray[j - gap] > newElement) 
            //        {
            //            intArray[j] = intArray[j - gap];
            //            j -= gap;
            //        }
            //        intArray[j] = newElement;
            //    }
            //}









            // Insertion Sort -- previous lecture
            //for (int firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            //{
            //    int newElement = intArray[firstUnsortedIndex];
            //    int i;
            //    for (i = firstUnsortedIndex; i > 0 && intArray[i - 1] > newElement; i--) 
            //    {
            //        intArray[i] = intArray[i - 1];
            //    }
            //    intArray[i] = newElement;
            //}

            //for (int firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            //{
            //    int newElement = intArray[firstUnsortedIndex];
            //    int i;
            //    for (i = firstUnsortedIndex; i > 0 && intArray[i-1] > newElement; i--)
            //    {
            //        intArray[i] = intArray[i - 1];
            //    }
            //    intArray[i] = newElement;
            //}


            // Selection Sort -- previous lecture

            //for (int lastUnsortedIndex = intArray.Length-1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            //{
            //    int largestElementIndex = 0;
            //    for (int i = 1; i <= lastUnsortedIndex; i++)
            //    {
            //        if (intArray[i] > intArray[largestElementIndex])
            //        {
            //            largestElementIndex = i;
            //        }
            //    }
            //    swap(intArray, largestElementIndex, lastUnsortedIndex);
            //}


            //for (int lastUnsortedIndex = intArray.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            //{
            //    int largestElementIndex = 0;
            //    for (int i = 1; i <= lastUnsortedIndex; i++)
            //    {  
            //        if (intArray[i] > intArray[largestElementIndex])
            //        {
            //            largestElementIndex = i;
                                         
            //        }
            //    }
            //    swap(intArray, largestElementIndex, lastUnsortedIndex);
            //}





            Console.WriteLine(string.Join(" ", intArray));
            Console.ReadLine();
        }

        public static void swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
