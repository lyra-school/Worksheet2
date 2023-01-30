/* Name: Lyra Karsaj
 * Date: 30/1/23
 * Desc: Odd number sum
 */
namespace Q1
{
    internal class Program
    {
        static int Sum(int n1, int n2)
        {
            int summation = 0;
            if(n2 > n1)
            {
                for(int i = n1; i <= n2; i++)
                {
                    if(i % 2 != 0)
                    {
                        summation = summation + i;
                    }
                }
            } else if(n1 > n2)
            {
                for (int i = n2; i <= n1; i++)
                {
                    if (i % 2 != 0)
                    {
                        summation = summation + i;
                    }
                }
            } else
            {
                summation = n2;
            }
            return summation;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter integer: ");
            int n2 = int.Parse(Console.ReadLine());
            int result = Sum(n1, n2);
            Console.WriteLine(result);
        }
    }
}