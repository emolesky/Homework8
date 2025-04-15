namespace NumberOfCalls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RecentCounter aRecentCounter = new RecentCounter();

            Console.WriteLine(aRecentCounter.Ping(1));
            Console.WriteLine(aRecentCounter.Ping(100));
            Console.WriteLine(aRecentCounter.Ping(3001));
            Console.WriteLine(aRecentCounter.Ping(3002));


        }
    }
}
