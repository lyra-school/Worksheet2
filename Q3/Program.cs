/* Name: Lyra Karsaj
 * Date: 30/1/23
 * Desc: Age bracket
 */
namespace Q3
{
    internal class Program
    {
        static bool AgeCheck(int age)
        {
            bool canPass = false;
            if(age >= 18 && age <= 21)
            {
                canPass = true;
            }
            return canPass;
        }
        static void Main(string[] args)
        {
            int age = 22;
            bool canPass = AgeCheck(age);
            Console.WriteLine(canPass);
        }
    }
}