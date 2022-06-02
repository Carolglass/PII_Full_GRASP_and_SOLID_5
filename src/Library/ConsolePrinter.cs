using System;

namespace Full_GRASP_And_SOLID
{
    //Se logra que la clase ConsolePrinter dependa de la interfaz IRecipeInside, en lugar de depender de la clase Recipe. 
    //Implementa IPrinter pero depende de IRecipeInside
    
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeInside recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}