namespace PracticeQ5_Y9Finals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e1 = 100;
            int e2 = 100;
            int e3 = 100;
            Console.WriteLine("Please enter the number of essays handed in late");
            int late = Convert.ToInt32(Console.ReadLine());
            int TotalMark = e1 + e2 + e3;
            if (late == 1)
            {
                TotalMark = TotalMark - 10;
            }
            else if (late > 1)
            {
                TotalMark = TotalMark / 2;
            }

            if (TotalMark <= 0)
            {
                TotalMark = 0;
            }
            Console.WriteLine("The total mark is: " + TotalMark);

        }
    }
}
