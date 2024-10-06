namespace Google50.Easy
{
    internal class ValidMountain
    {

        public bool find(int[] arr)
        {
            if (arr == null || arr.Length < 3)
            { 
                return false;
            }

            if (arr[0] > arr[1] || arr[arr.Length - 1] > arr[arr.Length - 2])
            {
                return false;
            }
            int i = 0;
            while (i <= arr.Length-3 && arr[i] < arr[i + 1])
            {
                i++;
            }
            while (i <= arr.Length-2 && arr[i] > arr[i + 1])
            {
                i++;
            }

            return i==arr.Length-1;
        }
    }
}
