namespace Multiple_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND (&&) Example - Are you a teen?

            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 13 && age <= 19)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are not a teenager.");

  
            // AND Task 1 - Going to the Movies
            string working;
            double money;
            Console.WriteLine("How much money do you have?");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you working (yes/no)?");
            working = Console.ReadLine().ToLower();
            if (working == "no" && money >= 20)
                Console.WriteLine("You can go to the movie");
            else
                Console.WriteLine("Sorry, you can't go to the movie.");


            // AND Task 2 - Access Granted???
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


            // OR (||) Example - Pizza Topping
            string topping;
            Console.WriteLine("What is the pizza topping?");
            topping = Console.ReadLine();
            if (topping == "pepperoni" || topping == "bacon")
                Console.WriteLine("I would eat this.");
            else
                Console.WriteLine("No thanks.");

            // Or Task 1 - Buss Pass
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12 || age >= 60)
                Console.WriteLine("The pass is $2.00");
            else
                Console.WriteLine("The pass is $3.50");

            // OR task 2 - Facourite Pet
            string animal;
            Console.WriteLine("What is your favourite type of animal");
            animal = Console.ReadLine().ToLower();
            if (animal == "cat" || animal == "dog")
                Console.WriteLine("Me Too!");
            else
                Console.WriteLine("To each their own.");

            // Or Task 3 - To Swim or not to Swim
            string weather;
            int temperature;
            Console.WriteLine("What is the temperature outside?");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the weather like (sunny/cloudy)?");
            weather = Console.ReadLine();
            if (weather == "sunny" || temperature > 25)
                Console.WriteLine("Swim Time!");
            else
                Console.WriteLine("Nap Time!");


        }
    }
}