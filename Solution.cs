using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStudents
{
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new Queue<int>(students);

            int sandwichIndex = 0;
            int unableToEatCount = 0;

            while(queue.Count > 0 && unableToEatCount < queue.Count)
            {
                int student = queue.Dequeue();

                if(student == sandwiches[sandwichIndex])
                {
                    sandwichIndex++;
                    unableToEatCount = 0;
                }
                else
                {
                    queue.Enqueue(student);
                    unableToEatCount++;
                }
            }
            return queue.Count;
        }
    }
}
