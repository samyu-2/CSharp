public class ArraysDemo{
    public void print(){
        int [] numbers=new int[5];
       for (int i = 0; i < numbers.Length; i++){
        numbers[i] = int.Parse(Console.ReadLine());
    }

    for(int i=0;i<numbers.Length;i++){
        Console.WriteLine("Number at index " + i + ": " + numbers[i]);
    }

  }
} 