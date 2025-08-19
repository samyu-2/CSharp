public class ClassAndObjectDemo
{
    string userName;
    string processor;
    string gpu;
    int ram;
    int storage;

    private static int NumberOfComputers = 0;
    int builtNumber;
    public ClassAndObjectDemo(string userName, string processor, string gpu, int ram, int storage)
    {
        this.userName = userName;
        this.processor = processor;
        this.gpu = gpu;
        this.ram = ram;
        this.storage = storage;
        NumberOfComputers++;
        builtNumber = NumberOfComputers;
    }

    public void pc()
    {
        Console.WriteLine("Built Number: "+ builtNumber);
        Console.WriteLine("Computer Details:");
        Console.WriteLine("User Name: " + userName);
        Console.WriteLine("Processor: " + processor);
        Console.WriteLine("GPU: " + gpu);
        Console.WriteLine("RAM: " + ram + " GB");
        Console.WriteLine("Storage: " + storage + " GB");
        
    }

}