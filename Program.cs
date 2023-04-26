using System;
using System.Drawing;

namespace POEPart1
{
    // Main program class
    public class Program
    {
        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RecipeApp!");

            Recipe recipe = null; // Initialize the recipe object to null
            bool exit = false; // Initialize the exit flag to false

            while (!exit) // Loop until the exit flag is set to true
            {
                Console.WriteLine("Enter a command (new, display, scale, reset, clear, exit):");

                string command = Console.ReadLine(); // Read the user's command

                switch (command)
                {
                    case "new":
                        Console.WriteLine("Enter the number of ingredients:");
                        int numIngredients = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the number of steps:");
                        int numSteps = int.Parse(Console.ReadLine());

                        recipe = new Recipe(numIngredients, numSteps);

                        for (int i = 0; i < numIngredients; i++)
                        {
                            Console.WriteLine($"Enter ingredient {i + 1} name:");
                            string name = Console.ReadLine();

                            Console.WriteLine($"Enter ingredient {i + 1} quantity:");
                            decimal quantity = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"Enter ingredient {i + 1} unit:");
                            string unit = Console.ReadLine();

                            recipe.SetIngredient(i, name, quantity, unit);
                        }

                        for (int i = 0; i < numSteps; i++)
                        {
                            Console.WriteLine($"Enter step {i + 1} description:");
                            string description = Console.ReadLine();

                            recipe.SetStep(i, description);
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Recipe created!");
                        Console.ResetColor();
                        break;

                    case "display":
                        if (recipe != null)
                        {
                            recipe.Display();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No recipe to display!");
                            Console.ResetColor();
                        }

                        break;

                   case "scale":
                        if (recipe != null)
                        {
                            Console.WriteLine("Enter the scale: (half, double, triple)");
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "half":
                                {
                                    recipe.Scale(0.5);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe scaled by a factor of 0,5 or half.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "double":
                                {
                                    recipe.Scale(2);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe scaled by a factor of 2 or double.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "triple":
                                {
                                    recipe.Scale(3);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe scaled by a factor of 3 or triple.");
                                    Console.ResetColor();
                                }
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Can't scale when there are no quantities to work with!");
                            Console.ResetColor();
                        }
                        break;


                    case "reset":
                        
                        if (recipe != null)
                        {
                            Console.WriteLine("Enter reset amount - please reset by the amount that you scaled by: (half, double, triple)");
                            string capture = Console.ReadLine();
                            
                            switch (capture)
                            {
                                case "half":
                                {
                                    recipe.Reset(0.5);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe divided/reset by 0,5 or half.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "double":
                                {
                                    recipe.Reset(2);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe divided/reset by 3 or triple.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "triple":
                                {
                                    recipe.Reset(3);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe divided/reset by 2 or double.");
                                    Console.ResetColor();
                                }
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Can't scale when there are no quantities to work with!");
                            Console.ResetColor();
                        }
                        break;
                    
                    
                    case "clear":
                        
                        if (recipe != null)
                        {
                            Console.WriteLine("Please confirm before clearing (yes, no)");
                            string confirmClear = Console.ReadLine();
                            switch (confirmClear)
                            {
                                case "yes":
                                {
                                    recipe.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("All recipe's cleared!");
                                    Console.ResetColor();
                                }
                                    break;

                                case "no":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("No recipe's were cleared! Going back to menu!");
                                    Console.ResetColor();
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cant clear when there is no recipe!");
                            Console.ResetColor();
                        }
                        break;
                    

                    case "exit":
                    {
                        exit = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Program exited successfully!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                        break;
                }
            }
        }
    }
}