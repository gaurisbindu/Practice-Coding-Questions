namespace Practice_Coding_Questions.FindFirstOccuranceOfTrueInSortedBoooleanArray
{
    public class SolutionOne_Naive
    {
        public static int FindFirstOccuranceOfTrue(bool[] values)
        {
           for (int i = 0;  i < values.Length; i++)
            {
                if (values[i])
                    return i;
            }

            return -1;
        }
    }
}
