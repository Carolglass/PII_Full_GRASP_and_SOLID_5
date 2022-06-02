namespace Full_GRASP_And_SOLID
{
    //Para aplicar el principio de inversión de dependencias (ISP), se define la abstracción de la que se quiere que ConsolePrinter y Recipe dependan; 
    //una interfaz IRecipeContent con un método GetTextToPrint
    public interface IRecipeInside
    {
        string GetTextToPrint();
    }
}
