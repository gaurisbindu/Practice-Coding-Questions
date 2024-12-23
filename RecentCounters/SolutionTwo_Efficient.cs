namespace Practice_Coding_Questions.RecentCounters
{
    public class SolutionTwo_Efficient
    {

        Queue<int> requests;
        public SolutionTwo_Efficient()
        {
            requests = new Queue<int>();
        }

        public int Ping(int t)
        {
            var lower = t - 3000;
            requests.Enqueue(t);

            while(requests.Peek() < lower)
            {
                requests.Dequeue();
            }

            return requests.Count;
            
        }
    }
}
