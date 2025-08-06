
// I maked sure that none of the questions are repeated untill all are displayed

using System;

class Program
{
    static void Main(string[] args)
    {


        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 4);
       

        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 5, 0, new List<string>());
       

        ReflectingActivity reflectingActivity = new ReflectingActivity(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.",
        60);
       

        Console.WriteLine(
         "Menu Options\n" +
         "1. Start Breathing Activity\n" +
         "2. Start Listing Activity\n" +
         "3. Start Reflecting Activity\n" +
         "4. Quit\n" +
         "Select a choice from the menu"
        );

        string input = Console.ReadLine();
        if (input == "1")
        {
            breathingActivity.Run();
        }
        else if (input == "2")
        {
            listingActivity.Run();
        }
        else if (input == "3")
        {
            reflectingActivity.Run();
        }
        else if (input == "4")
        {
            Environment.Exit(0);
        }
    }
}
