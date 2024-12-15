using System;

class Program
{
    static void Main(string[] args)
    {
        ReflectionActivity a1 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. Please just think of the answers to the following do not write or type them down during the activity.");
        BreathingActivity a2 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ListingActivity a3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. Please type your answers and hit enter after each one.");

        string selection;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfullness Activity Menu.\nPlease select from the options below:");
            Console.WriteLine("1. Breathing\n2. Self-Reflection\n3. Listing Thoughts\n4. Quit");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                a2.Run();
            }
            else if (selection == "2")
            {
                a1.Run();
            }
            else if
            (selection == "3")
            {
                a3.Run();
            }
        } while (selection != "4");
        Console.WriteLine("Thank you for taking the time to do this.");
        Thread.Sleep(2000);

    }

}