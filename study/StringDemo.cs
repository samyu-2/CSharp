
public class StringDemo{
    public void print(){
        string a="hello";
        Console.WriteLine("String: " + a);

        string b = "world";
        Console.WriteLine("StringConcedination: "+ a+b);
        Console.WriteLine("StringLength: " + a.Length);
        Console.WriteLine("StringUpperCase: " + a.ToUpper());
        Console.WriteLine("StringLowerCase: " + a.ToLower());
        Console.WriteLine("StringContains: " + a.Contains("lo"));
        Console.WriteLine("StringIndexOf: " + a[1]);
        Console.WriteLine("StringIndexOf: " + a.IndexOf("llo"));
        Console.WriteLine("Substring: " + a.Substring(1, 3));
    }
}