namespace BaseballGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            string[] operation1 = { "5", "2", "C", "D", "+" };
            Console.WriteLine(aSolution.CalPoints(operation1));
            string[] operation2 = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Console.WriteLine(aSolution.CalPoints(operation2));

        }
    }
}
