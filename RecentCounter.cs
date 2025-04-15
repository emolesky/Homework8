using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfCalls
{
    public class RecentCounter
    {
        private Queue<int> requests;
        public RecentCounter()
        {
            requests = new Queue<int>();
        }

        public int Ping(int t)
        {
            requests.Enqueue(t);

            while ( requests.Peek() < t -3000)
            {
                requests.Dequeue();
            }
            return requests.Count;
        }
    }
}
