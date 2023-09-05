namespace PracticeProblems
{
    internal class ConvertFirstLetterAsCapital
    {
        public static void Capital()
        {
            Console.WriteLine("Arry size");
            int arr = Convert.ToInt32(Console.Read());

            string[] array = new string[arr];
            Console.WriteLine("Add elements in array");
            for (int i = 0; i < arr; i++)
            {
                array[i] = Console.ReadLine();
            }
            Display(array);
        }
        public static void Display(string[] array)
        {
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }
        /*  for (int i = 0; i < array[i]; i++)
          {
              if (array[i - 1] == ' ' && array[i] != ' ')
              {
                  Console.WriteLine(array[i]);
              }
          }*/

    }
}
