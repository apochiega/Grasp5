using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Sender recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}