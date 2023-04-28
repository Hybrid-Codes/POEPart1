using System;

namespace POEPart1
{
    // Main program class
    public class Program
    {
        // Main method
        static void Main(string[] ags)
        {
            // set console color to cyan
            Console.ForegroundColor = ConsoleColor.Cyan;
            // print welcome message to the console
            Console.WriteLine($"Welcome to RecipeApp!");
            // reset console color
            Console.ResetColor();

            // Initialize the recipe object to null 
            Recipe recipe = null;
            // Initialize the exit flag to false
            bool exit = false;

            // Loop until the exit flag is set to true
            while (!exit) 
            {
                // set console color to white
                Console.ForegroundColor = ConsoleColor.White;
                // print prompt to the console
                Console.WriteLine("Enter a command (new, display, scale, reset, clear, exit):");
                // reset console color
                Console.ResetColor();
                // Read the user's command input
                string command = Console.ReadLine(); 

                switch (command)
                {
                    case "new":
                        // create a new recipe
                        // set console color to cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Enter the name of the recipe: ");
                        // reset console color
                        Console.ResetColor();
                        // read recipe name from console input
                        string rName = Console.ReadLine();
                        
                        // set console color to cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Enter the number of ingredients:");
                        // reset console color
                        Console.ResetColor();
                        // read number of ingredients from console input
                        int numIngredients;
                        string line = Console.ReadLine();
                        
                        // try to parse number of ingredients from the input string
                        try
                        {
                            numIngredients = Int32.Parse(line);
                        }
                        catch (FormatException)
                        {
                            // print error message if the input is not a number and go back to the "new" case
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0} is not a number!", line);
                            // reset console color
                            Console.ResetColor();
                            goto case "new";
                        }

                        // set console color to cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Enter the number of steps:");
                        // reset console color
                        Console.ResetColor();
                        // read number of steps from console input
                        int numSteps;
                        string inputSteps = Console.ReadLine();
                        
                        // try to parse number of steps from the input string
                        try
                        {
                            numSteps = Int32.Parse(inputSteps);
                        }
                        catch (FormatException)
                        {
                            // print error message if the input is not a number and go back to the "new" case
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0} is not a number!", inputSteps);
                            // reset console color
                            Console.ResetColor();
                            goto case "new";
                        }

                        // create a new Recipe object with the given number of ingredients and steps
                        recipe = new Recipe(numIngredients, numSteps);
    
                        // loop over the number of ingredients to get their details
                        for (int i = 0; i < numIngredients; i++)
                        {
                            // set console color to cyan
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Enter ingredient {i + 1} name:");
                            // reset console color
                            Console.ResetColor();
                            // read ingredient name from console input
                            string name = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Enter ingredient {i + 1} quantity:"); // Prompts user to enter ingredient quantity
                            Console.ResetColor();
                            decimal quantity;
                            string inputQuantity = Console.ReadLine();
                            
                            // try to parse number ingredients from the input string
                            try
                            {
                                quantity = decimal.Parse(inputQuantity);
                            }
                            
                            catch (FormatException)
                            {
                                // print error message if the input is not a number and go back to the "new" case
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0} is not a number!", inputQuantity);
                                Console.ResetColor();
                                goto case "new";
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Enter ingredient {i + 1} unit of measurement (teaspoons, tablespoons, cups):");
                            Console.ResetColor();
                            string unit = Console.ReadLine();
                           
                           
                            recipe.SetIngredient(i, name, quantity, unit);
                        }

                        // Iterate through each recipe step and prompt user to enter a description
                        for (int i = 0; i < numSteps; i++) 
                        {
                            // Set console color to cyan and display step number prompt
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Enter step {i + 1} description:");
                            Console.ResetColor();

                            // Read user input for step description and store in variable
                            string description = Console.ReadLine();

                            // Update recipe step with description
                            recipe.SetStep(i, description);
                        }
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Recipe created!");
                        Console.ResetColor();
                        break;

                    case "display":
                        if (recipe != null) // If recipe is not null run the method call
                        {
                            recipe.Display(); // method call from recipe class
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No recipe to display!");
                            Console.ResetColor();
                        }

                        break;

                   case "scale":
                        if (recipe != null) // If recipe is not null run the method call
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Enter the scale: (half, double, triple)");
                            Console.ResetColor();
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "half":
                                {
                                    recipe.Scale(0.5); // method call from recipe class
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe scaled by a factor of 0,5 or half.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "double":
                                {
                                    recipe.Scale(2); // method call from recipe class
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe scaled by a factor of 2 or double.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "triple":
                                {
                                    recipe.Scale(3); // method call from recipe class
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe scaled by a factor of 3 or triple.");
                                    Console.ResetColor();
                                }
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // If recipe is null run this error message
                            Console.WriteLine("Can't scale when there are no quantities to work with!");
                            Console.ResetColor();
                        }
                        break;


                    case "reset":
                        
                        if (recipe != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Enter reset amount - please reset by the amount that you scaled by: (half, double, triple)");
                            Console.ResetColor();
                            string capture = Console.ReadLine();
                            
                            switch (capture)
                            {
                                case "half":
                                {
                                    recipe.Reset(0.5); // method call from recipe class
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe divided/reset by 0,5 or half.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "double":
                                {
                                    recipe.Reset(2); // method call from recipe class
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe divided/reset by 2 or double.");
                                    Console.ResetColor();
                                }
                                    break;

                                case "triple":
                                {
                                    recipe.Reset(3); // method call from recipe class
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Recipe divided/reset by 3 or triple.");
                                    Console.ResetColor();
                                }
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // If recipe is null run this error message
                            Console.WriteLine("Can't scale when there are no quantities to work with!");
                            Console.ResetColor();
                        }
                        break;
                    
                    
                    case "clear":
                        
                        if (recipe != null) 
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Please confirm before clearing (yes, no)");
                            Console.ResetColor();
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
