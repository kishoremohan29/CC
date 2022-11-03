using System;

public class Program      
{
    //implement code here
    public static void Main(string[] args)
    {
        string sentence, reverse="";
        
        Console.WriteLine("Enter a string");
        sentence = Console.ReadLine();
        
        string[] temp = sentence.Split();
        
        for(int i = temp.Length-1; i >= 0; i--)
        {
            reverse += temp[i] + " ";
        }
        Console.WriteLine(reverse);
    }
}