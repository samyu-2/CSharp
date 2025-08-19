public class DataTypes
{
   public void print()
   {
      string str = "hello";
      char ch = 'h';
      int num = 10;
      float f = 10.5f;
      double d = 20.5;
      decimal dec = 30.5m; // very accurate for financial calculations
      bool isTrue = true;
      Console.WriteLine("String: " + str);
      Console.WriteLine("Character: " + ch);
      Console.WriteLine("Integer: " + num);
      Console.WriteLine("Float: " + f);
      Console.WriteLine("Double: " + d);
      Console.WriteLine("Decimal: " + dec);
      Console.WriteLine("Boolean: " + isTrue);
     }
}