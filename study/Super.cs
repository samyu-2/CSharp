public class Super
{
    public virtual void print()
    {
        Console.WriteLine("I am from parent");
    }

    public void sayHi(string msg)
    {
        Console.WriteLine(msg);
    }

    public void sayHello(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class Sub : Super
{
    public override void print()
    {
        Console.WriteLine("I am from child");
        base.print();
        base.sayHi("Hi from Sub via base");
        base.sayHello("Hello from Sub via base");
    }
}