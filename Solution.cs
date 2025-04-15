using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class Solution
    {
        public int CalPoints(string[] operations)
        {
            Stack<int> record = new Stack<int>();
            foreach (string operation in operations)
            {
                if( operation == "+")
                {
                    int top = record.Pop();
                    int newTop = top + record.Peek();
                    record.Push(top);
                    record.Push(newTop);
                }
                else if(operation =="D")
                {
                    record.Push(2 * record.Peek());
                }
                else if (operation == "C")
                {
                    record.Pop();

                }
            }
            int sum = 0;
            foreach( int score in record)
            {
                sum += score;
            }
            return sum;
        }
    }
}
