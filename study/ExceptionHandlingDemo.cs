public class ExceptionHandlingDemo{
    public void print(){
        try{
        Console.Write("Enter a number: ");
        int num1=int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine("The result of division is: " + (num1 / num2));
        }
        catch(Exception e){
            Console.Write(e.Message);
        }
        finally{
            Console.WriteLine("\nExecution completed.");
        }

    }
}