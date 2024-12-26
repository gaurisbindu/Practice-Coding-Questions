namespace Practice_Coding_Questions.FindFirstOccuranceOfTrueInSortedBoooleanArray
{
    public class SolutionTwo_Efficient
    {
        public static int FindFirstOccuranceOfTrue(bool[] values)
        {
            var start = 0;
            var end = values.Length - 1;

            while (start <= end)
            {
                if(start == end)
                    return values[start] ? start : -1;

                var mid = start + (end - start) / 2;

                if (values[mid] == true)
                {
                    if (mid - 1 >= 0 && values[mid - 1] == true)
                        end = mid + 1;
                    else
                        return mid;
                }
                else if (values[mid] == false)
                {
                    start = mid + 1;
                }
            }

            return -1;
        }
    }
}
