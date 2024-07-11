namespace ProgramsForLearning.Program6.Models;
public class BaseClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void DisplayMessage()
    {
        Console.WriteLine("Esto es un mensaje que viene de la clase base");

    }
}
