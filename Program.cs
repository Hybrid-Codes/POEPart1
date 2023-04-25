using System;

namespace POEPart1
{
    
    // Main program class
   public class Program 
    {
        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RecipeApp!");

            Recipe recipe = null;   // Initialize the recipe object to null
            bool exit = false;      // Initialize the exit flag to false

            while (!exit)   // Loop until the exit flag is set to true
            {
                Console.WriteLine("Enter a command (new, display, scale, reset, clear, exit):");
                
                string command = Console.ReadLine();  // Read the user's command

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
                        Console.WriteLine("Recipe created!");
                        break;

                    case "display":
                        if (recipe != null)
                        {
                            recipe.Display();
                        }
                        else
                        {
                            Console.WriteLine("No recipe to display!");
                        }

                        break;

                    case "scale":
                        Console.WriteLine("Enter the scale: (half, double, triple)");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "half":
                            {
                                if (recipe != null)
                                {
                                    recipe.Scale(0.5);
                                    Console.WriteLine("Recipe scaled by a factor of 0,5 or half.");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Cant scale when there are no quantities to work with!");
                                }
                            }
                                break;
                                
                            case  "double":
                            {
                                if (recipe != null)
                                {
                                    recipe.Scale(2);
                                    Console.WriteLine("Recipe scaled by a factor of 2 or double.");
                                }
                                else
                                {
                                    Console.WriteLine("Cant scale when there are no quantities to work with!");
                                }
                            }
                                break;
                                
                            case "triple":
                            {
                                if (recipe != null)
                                {
                                    recipe.Scale(3);
                                    Console.WriteLine("Recipe scaled by a factor of 3 or triple.");
                                }
                                else
                                {
                                    Console.WriteLine("Cant scale when there are no quantities to work with!");
                                }
                            }
                                break;
                        }
                        break;
                        
                    case "reset":
                        Console.WriteLine("Enter reset amount - please reset by the amount that you scaled by: (half, double, triple)");
                        string capture = Console.ReadLine();
                        switch (capture)
                        {
                            case "half":
                            {
                                if (recipe != null)
                                {
                                    recipe.Reset(0.5);
                                    Console.WriteLine("Recipe divided/reset by 0,5 or half.");

                                }
                                else
                                {
                                    Console.WriteLine("Can't reset when there are no quantities to work with!");
                                }
                            }
                                break;
                                
                            case  "double":
                            {
                                if (recipe != null)
                                {
                                    recipe.Reset(2);
                                    Console.WriteLine("Recipe divided/reset by 2 or double.");
                                }
                                else
                                {
                                    Console.WriteLine("Can't reset when there are no quantities to work with!");
                                }
                            }
                                break;
                                
                            case "triple":
                            {
                                if (recipe != null)
                                {
                                    recipe.Reset(3);
                                    Console.WriteLine("Recipe divided/reset by 2 or double.");
                                }
                                else
                                {
                                    Console.WriteLine("Can't reset when there are no quantities to work with!");
                                }
                            }
                                break;
                        }
                        break;

                    case "clear":
                        Console.WriteLine("Please confirm before clearing (yes, no)");
                        string confirmClear = Console.ReadLine();
                        switch (confirmClear)
                        {
                            case "yes":
                                if (recipe != null)
                                {
                                    recipe.Clear();
                                    Console.WriteLine("All recipe's cleared!");
                                }
                                else
                                {
                                    Console.WriteLine("Cant clear when there is no recipe!");
                                }

                                break;
                            case "no":
                                Console.WriteLine("No recipe's were cleared! Going back to menu!");
                                continue;
                                
                                
                        }

                        break;


                    case "exit":
                    {
                        exit = true;
                        Console.WriteLine("Program exited successfully!");
                        Console.ReadKey();
                    }
                        break;
                }
            }
        }

    }
}
    
    
  
    

    
                                   
