namespace POEPart1
{

    // Step class representing a step in a recipe
    class Step
    {
        public string Description { get; set; }    // Description of the step

        // Override the ToString() method to display the step description
        public override string ToString()
        {
            return Description;
        }
    }
}