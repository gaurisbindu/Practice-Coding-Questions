namespace Practice_Coding_Questions.RecentCounters
{
    public class SolutionOne_Naive
    {

        Queue<int> requests;
        public SolutionOne_Naive()
        {
            requests = new Queue<int>();
        }

        public int Ping(int t)
        {
            var lower = t - 3000;
            var upper = t;

            var answer = new Queue<int>();
            foreach (var item in requests)
            {
                if (item >= lower && item <= upper)
                {
                    answer.Enqueue(item);
                }
            }

            if (t >= lower && t <= upper)
            {
                requests.Enqueue(t);
                answer.Enqueue(t);
            }

            var n = answer.Peek();
           
            return answer.Count(); // 1, 2
        }
    }
}
