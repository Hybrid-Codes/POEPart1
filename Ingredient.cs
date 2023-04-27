namespace POEPart1
{

    // Ingredient class representing an ingredient in a recipe
    class Ingredient
    {

       
        public string Name { get; set; }     // Name of the ingredient
        public decimal Quantity { get; set; }    // Quantity of the ingredient
        public string Unit { get; set; }     // Unit of measurement for the ingredient
        
        

        // Override the ToString() method to display the ingredient information in a formatted string
        public override string ToString()
        {
            return $"{Name}: {Quantity} {Unit}";
        }
    }
}