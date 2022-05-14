﻿using System.Text.RegularExpressions;
using Unit4Lab2_CircleLab;

List<Circle> allCircles = new List<Circle>();

Console.WriteLine("Welcome to the Circle Objects Program!");
PauseAndClearScreen();

bool runningProgram = true;
while (runningProgram)
{
    bool calculatingCircleStuff = true;
    while (calculatingCircleStuff)
    {
        Console.Write("Enter the radius of your circle: ");
        string userRadius = Console.ReadLine();
        bool isANumber = double.TryParse(userRadius, out double theRadius);
        if (isANumber)
        {
            if (theRadius > 0)
            {
                Circle thisCircle = new Circle(theRadius);
                Console.WriteLine();
                Console.WriteLine(thisCircle.CalculateFormattedCircumference());
                Console.WriteLine(thisCircle.CalculateFormattedArea());
                PauseAndClearScreen();
                allCircles.Add(thisCircle);
                calculatingCircleStuff = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, we need a number greater than zero to calculate a Circumference. Please try again.");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, that doesn't appear to be a number. Let's try again.");
            PauseAndClearScreen();
        }
    }
    if (allCircles.Count <= 0)
    {
        Console.WriteLine($"So far, we haven't calculated information for any circles yet!");
        Console.WriteLine();
    }
    else if (allCircles.Count == 1)
    {
        Console.WriteLine($"So far, we've calculated the information for {allCircles.Count} circle.");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"So far, we've calculated the information for {allCircles.Count} circles.");
        Console.WriteLine();
    }
    runningProgram = WannRestart();
}
Console.WriteLine($"Thank you for using the Circle Object Program to calculate information for {allCircles.Count} circles today!");
Console.WriteLine("Goodbye...");

static void PauseAndClearScreen()
{
    Console.WriteLine();
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}
static bool WannRestart()
{
    bool askingUser = true;
    string yesInput = "[yY][eE][sS]";
    string noInput = "[nN][oO]";
    while (askingUser)
    {
        Console.WriteLine("Would you like to calculate the information for another circle?");
        Console.WriteLine("Enter 'Yes' or 'No' below.");
        Console.Write("Your Choice: ");
        string userChoice = Console.ReadLine();
        if (Regex.IsMatch(userChoice, yesInput))
        {
            PauseAndClearScreen();
            return true;
        }
        else if (Regex.IsMatch(userChoice, noInput))
        {
            PauseAndClearScreen();
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, I didn't understand that choice. Please try again.");
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
    return false;
}