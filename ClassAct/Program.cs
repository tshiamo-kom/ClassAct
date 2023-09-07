namespace ClassAct
{
    internal class Program
    {
        #region recursive
        static void Main(string[] args)
        {

            string[] words = { "Code", "Sleep", "Repeat" };
            PrintSubset(words, 0, "");
        }

        private static void PrintSubset(string[] words, int currentIndex, string currentSubset)
        {
            if (currentIndex == words.Length)
            {
                Console.WriteLine("(" + currentSubset.Trim() + ")");
                return;
            }

            // Include the current word in the subset
            PrintSubset(words, currentIndex + 1, currentSubset + words[currentIndex] + " ");

            // Exclude the current word from the subset
            PrintSubset(words, currentIndex + 1, currentSubset);
        }
        #endregion

        #region remove negative numbers
        static void Main()
        {
            int[] array = { 19, -10, 12, -6, -3, 34, -2, 5 };
            int[] newArray = RemoveNegativeNumbers(array);

            Console.WriteLine("Original array:");
            PrintArray(array);

            Console.WriteLine("New array:");
            PrintArray(newArray);
        }

        static int[] RemoveNegativeNumbers(int[] array)
        {
            return array.Where(num => num >= 0).ToArray();
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region counter
        static void Main()
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            CountOccurrences(array);
        }

        static void CountOccurrences(int[] array)
        {
            // Create a dictionary to store the count of each element
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (elementCount.ContainsKey(num))
                {
                    elementCount[num]++;
                }
                else
                {
                    elementCount[num] = 1;
                }
            }

            // Iterate over the dictionary and print the counts
            foreach (var kvp in elementCount)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value} times");
            }

        }
        #endregion

        #region random number
        static void Main()
        {
            var (oddNumbers, evenNumbers) = GenerateRandomNumbers();

            Console.WriteLine("Odd Numbers:");
            foreach (var odd in oddNumbers)
            {
                Console.WriteLine(odd);
            }

            Console.WriteLine("Even Numbers:");
            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }
        }

        static (List<int> oddNumbers, List<int> evenNumbers) GenerateRandomNumbers()
        {
            Random random = new Random();
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            while (oddNumbers.Count < 8 || evenNumbers.Count < 8)
            {
                int randomNumber = random.Next(10, 26);

                if ((randomNumber % 2 == 0) && (evenNumbers.Count < 8) && !evenNumbers.Contains(randomNumber))
                {
                    evenNumbers.Add(randomNumber);
                }
                else if ((randomNumber % 2 != 0) && (oddNumbers.Count < 8) && !oddNumbers.Contains(randomNumber))
                {
                    oddNumbers.Add(randomNumber);
                }
            }

            return (oddNumbers, evenNumbers);
        }

        #endregion
    }
}