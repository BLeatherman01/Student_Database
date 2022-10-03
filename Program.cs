namespace Student_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("which student would you like to learn about? Please enter a number 1-6");
            bool keepGoing = true;

            while (keepGoing)
            {

                string[] studentNames = { "Eric", "Kyle", "Kenny", "Stan", "Butters", "Timmy" };
                string[] homeTown = { "Grand Rapids", "Livonia", "Detroit", "Ann Arbor", "Flint", "Saginaw" };
                string[] favoriteFood = { "Hamburgers", "Hot dogs", "Salad", "Paczkis", "CheeseSteak", "Tacos" };

                int length = studentNames.Length;

                int userInput = GetUserStudentNumber(length);

                string studentSearch = studentNames[userInput - 1];
                string favoriteSearch = favoriteFood[userInput - 1];
                string hometownSearch = homeTown[userInput - 1];

                bool category = GetUserCategory();
                if (category == true)
                {
                    Console.WriteLine(studentSearch + " is from " + hometownSearch);
                }
                else
                {
                    Console.WriteLine(studentSearch + "'s" + " favorite food is " + favoriteSearch);
                }

                keepGoing = GoAgain();
            }

        }
        public static bool GoAgain()
        {
            Console.WriteLine("Would you like to learn about another student? Please enter Yes or No");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("which student would you like to learn about? Please enter a number 1-6");
                return true;

            }
            else if (userInput == "no" || userInput == "n")
            {

                return false;
            }
            else
            {
                Console.WriteLine("Please enter Yes or No");
                return GoAgain();
            }

        }

        public static int GetUserStudentNumber(int arrayLength)
        {
            //Console.WriteLine("which student would you like to learn about? Please enter a number 1-6");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number <= 0 || number > arrayLength)
            {
                Console.WriteLine("Please enter a number that is 1-6");
                return GetUserStudentNumber(arrayLength);
            }
            return number;
        }

        public static bool GetUserCategory()
        {
            Console.WriteLine("which category would you like to display. Hometown or Favorite food");

            string userInput = Console.ReadLine().ToLower();
            
            if (userInput.Contains("home") || userInput.Contains("town"))
            {
                return true;
            }
            else if (userInput.Contains("favorite") || userInput.Contains("food"))
            {
                return false;
            }
            else
            {
                Console.WriteLine("That was an invalid input. Please enter either Hometown and Favorite food");
                return GetUserCategory();
            }

        }

    }
}