/* Name: Lyra Karsaj
 * Date: 30/1/23
 * Desc: BMI calculator
 */
namespace Q4
{
    internal class Program
    {
        static double GetBMI(double mass, double height)
        {
            double BMI = mass / Math.Pow(height, 2);
            return BMI;
        }
        static void Main(string[] args)
        {
            double mass = 57;
            double height = 1.7;
            double BMI = GetBMI(mass, height);
            Console.WriteLine(BMI);
        }
    }
}