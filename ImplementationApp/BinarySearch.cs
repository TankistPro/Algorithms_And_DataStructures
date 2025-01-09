namespace ImplementationApp
{
    internal class BinarySearch
    {
        public int? BinarySearchImp(int[] array, int searchedValue)
        {
            int leftPointer = 0;
            int rightPointer = array.Length - 1;
            

            while (leftPointer <= rightPointer)
            {
                int middle = (leftPointer + rightPointer) / 2;

                int currentValue = array[middle];

                if (currentValue == searchedValue) return middle;
                if(currentValue > searchedValue)
                {
                    rightPointer = middle - 1;
                }
                if (currentValue < searchedValue) 
                { 
                    leftPointer = middle + 1;
                }

            }

            return null;
        }
    }

    public static class BinarySearchMain
    {
        public static void RunBinarySearch()
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8];
            BinarySearch binarySearch = new BinarySearch();

            int? value = binarySearch.BinarySearchImp(array, 5);

            Console.WriteLine(value != null ? value : "None");
        }
    }
}
