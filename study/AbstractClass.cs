public abstract class AbstractClass
{
    public abstract void MakeSound();
    public void sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

class Dog : AbstractClass
{
    public override void MakeSound()
    {
        Console.WriteLine("Barking");
    }
}

