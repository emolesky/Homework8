namespace NumberOfStudents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] students = { 1, 1, 0, 0 };
            int[] sandwiches = { 0, 1, 0, 1 };
            Console.WriteLine(aSolution.CountStudents(students, sandwiches));
        }
    }
}
