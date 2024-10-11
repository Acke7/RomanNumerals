namespace RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal result = 0;
            int number = 0;
            Dictionary<char, int> romanToInt = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            while (true)
            {
                Console.WriteLine("Write roman numerals to convert them to numeric values");
                string s = Console.ReadLine().ToUpper();

               
                    if (s.Length >= 11)
                    {
                        Console.WriteLine("Write 11 max numerals ");
                        break;
                    }
               
                char[] charArray = s.ToCharArray();
                
                List<decimal> numberList = new List<decimal>();


                foreach (var item in charArray)
                {
                    if (romanToInt.ContainsKey(item))
                    {
                        numberList.Add(romanToInt[item]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Roman numeral.");
                        break;
                    }

                }

                for (int i = 0; i < numberList.Count; i++)
                {
                    // If we are not at the last element, compare current element with the next
                    if (i + 1 < numberList.Count)
                    {
                        if (numberList[i] < numberList[i + 1])
                        {
                            // Subtract current element from the next
                            result -= numberList[i];
                        }
                        else
                        {
                            // Add current element to the result
                            result += numberList[i];
                        }
                    }
                    else
                    {
                        // Add the last element to the result
                        result += numberList[i];
                    }
                }
                if (result> 3999|| result < 1 )
                {
                    Console.WriteLine("invalid Roman number");
                }
                Console.WriteLine(result);
            }
        }
    }
}
