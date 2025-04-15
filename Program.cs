namespace ValidParaentheses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            Console.WriteLine(aSolution.isValid("()"));
            Console.WriteLine(aSolution.isValid("{})"));
            Console.WriteLine(aSolution.isValid("{]"));
            Console.WriteLine(aSolution.isValid("(){}[]"));

        }
    }
}
