public interface Interface
{
    void MakeSound();

    void sleep()
    {
        Console.WriteLine("Sleeping");
    }
}


public class Goat : Interface
{
    public void MakeSound()
    {
        Console.WriteLine("maaa....");
    }
    
}