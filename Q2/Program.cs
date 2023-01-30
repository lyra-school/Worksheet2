/* Name: Lyra Karsaj
 * Date: 30/1/23
 * Desc: Array sort checker
 */
namespace Q2
{
    internal class Program
    {
        static bool IsSorted(int[] x)
        {
            bool sorted = true;
            int? lastOne = null;
            foreach(int i in x)
            {
                if(lastOne == null || i >= lastOne)
                {
                    lastOne = i;
                }
                else
                {
                    sorted = false;
                }
            }
            return sorted;
        }
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            bool result = IsSorted(x);
            Console.WriteLine(result);
        }
    }
}