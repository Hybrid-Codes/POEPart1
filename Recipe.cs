namespace POEPart1
{

    // Recipe class representing a recipe with ingredients and steps
    class Recipe
    {
        private Ingredient[] ingredients;     // Array of ingredients in the recipe
        private Step[] steps;      // Array of steps in the recipe

        // Constructor to create a new Recipe object with the specified number of ingredients and steps
        public Recipe(int numIngredients, int numSteps)
        {
            ingredients = new Ingredient[numIngredients];
            steps = new Step[numSteps];
        }

        // Method to set the ingredient at the specified index with the specified name, quantity, and unit
        public void SetIngredient(int index, string name, decimal quantity, string unit)
        {
            ingredients[index] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }

        // Method to set the step at the specified index with the specified description
        public void SetStep(int index, string description)
        {
            steps[index] = new Step { Description = description };
        }

       
        // Method to display the recipe information, including the ingredients and steps
        public void Display()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        // Method to scale the recipe quantities by the specified factor
        public void Scale(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= (decimal)factor;
            }
        }
        public void Convert()
        {
            double teaSpoon = 0;
            double tableSpoon = 0;
            double cup = 0;
        }


        // Method to reset the recipe quantities to their original values
        public void Reset(double scaleFactor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity /= (decimal)scaleFactor; // Divided by the factor that was chosen in Scale method
            }
        }

        // Method to clear the recipe data and start a new recipe
        public void Clear()
        {
            Array.Clear(ingredients, 0, ingredients.Length);
            Array.Clear(steps, 0, steps.Length);
        }
    }
}