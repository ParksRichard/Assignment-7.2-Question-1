//implement a shell sort on an unsorted array of numbers. 
//take input from user


//gap? = h, setting the whole divide/conquer thing
namespace Assignment_7._2_Question_1
{
    //ripped from the example
    class ShellSort
    {
        static void Sort(int[] array)
        {
            int n = array.Length;
        }

        int sort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];

                    int j;
                    //gaps are weird and complex
                    for (j = i; 
                        j >= gap && 
                        arr[j - gap] > temp; 
                        j -= gap)
                        arr[j] = arr[j - gap];
                        arr[j] = temp;
                    //what a nightmare, why not be somewhat normal?
                    //wouldn't this be limiting in some ways?
                }
            }
            return 0;
        }
        static void Print(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            //taking user input, not hardcode

            //int[] arr = { 12, 34, 54, 2, 3 };
            //Console.Write("Array before sorting :\n");
            //printArray(arr);
          
            //ShellSort ob = new ShellSort();
            //ob.sort(arr);
            
            //Console.Write("Array after sorting :\n");
            //printArray(arr);

            Console.WriteLine("Please enter a series of any numbers seperated by spaces:");
            string input = Console.ReadLine();
            //stringuser input made into array
            string[] inputarray = input.Split(' ');
            int[] array = new int[inputarray.Length];
            //validate input for array
            bool valid = true;
            for (int i = 0; i < inputarray.Length; i++)
            {
                if (int.TryParse(inputarray[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Doesn't count, try again.");
                    return;
                }
            }

            if (valid) //if it works print it
            {
                ShellSort sorter = new ShellSort();
                sorter.sort(array); //sorty

                Console.WriteLine("");
                Console.WriteLine("Sorted Array: ");
                Print(array);
            }
        }
    }
}
