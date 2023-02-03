namespace Multiple_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND (&&) Example

            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 13 && age <= 19)
                Console.WriteLine("You are a teenager");
            else
                Console.WriteLine("You are not a teenager");

            // AND Tasks
            // Task 1
            string working;
            double money;
            Console.WriteLine("How much money do you have?");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you working (yes/no)?");
            working = Console.ReadLine().ToLower();
            if (working == "no" && money >= 20)
                Console.WriteLine("You can go to the movie");
            else
                Console.WriteLine("Sorry, you can't go.");
            // Task 2
            string password;
            int guesses;
            Console.WriteLine("How many guesses did you take?");
            guesses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the password?");
            password = Console.ReadLine();
            if (guesses < 5 && password == "santa")
                Console.WriteLine("Open Sesame.");
            else
                Console.WriteLine("Access Denied.");


            // OR (||) Example

            
        }
    }
}