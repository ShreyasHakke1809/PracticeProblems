namespace PracticeProblems
{
    internal class SumOfAllDigits
    {
        public static void Addition()
        {
            Console.WriteLine("Give me number of element wants to add");
            int input = Convert.ToInt32(Console.ReadLine());

            int[] add = new int[input];

            Console.WriteLine("Add Elements");
            for (int i = 0; i < input; i++)
            {
                add[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(add.Sum());
        }
    }
}
