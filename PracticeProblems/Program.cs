namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Problems");
            Console.WriteLine("Please Choose option from given");
            Console.WriteLine("\n1.Pattern\n2.Find max and min element in array\n3.Find lowest numbers and their sum\n4.Reverse a given string\n5.Rectangle Pattern\n6.Sum of given digits\n7.Print unique numbers\n8.Duplicate elements\n9.Frequency of Element");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Pattern.Pattern1();
                    break;
                case 2:
                    MaxAndMinElementInArray.MaxAndMin();
                    break;
                case 3:
                    FindLowestElement.FindLowest();
                    break;
                case 4:
                    ReverseString.Reverse();
                    break;
                case 5:
                    RectanglePattern.Pattern();
                    break;
                case 6:
                    SumOfAllDigits.Addition();
                    break;
                case 7:
                    PrintUniqueElements.Unique();
                    break;
                case 8:
                    DuplicateElements.Duplicate();
                    break;
                case 9:
                    FrequencyOfElement.Frequency();
                    break;
                case 10:
                    ConvertFirstLetterAsCapital.Capital();
                    break;
            }
        }
    }
}