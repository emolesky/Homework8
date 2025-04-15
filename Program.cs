namespace FindPivot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] nums1 = { 1, 7, 3, 6, 5, 6 };
            Console.WriteLine(aSolution.PivotIndex(nums1));
            int[] nums2 = { 1, 2, 3 };
            Console.WriteLine(aSolution.PivotIndex(nums2));
            int[] nums3 = { 2, 1, -1 };
            Console.WriteLine(aSolution.PivotIndex(nums3));
        }
    }
}
