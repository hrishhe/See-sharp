public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int left = 0; int right = input.Length - 1;
        int mid = left + right / 2;


        if (input.Length == 0)
        {
            return -1;
        }
        if (value == input[left])
            return left;

        if (value == input[right])
            return right;
            

        while (left < right)
        {
            if (value == input[mid])
                break;

            else if (value < input[mid])

            {
                right = mid - 1;
            }

            else
                left = mid + 1;

            mid = (left + right) / 2;
            

        }


        if (value == input[mid])
            return mid;

        else
            return -1;
    }
}