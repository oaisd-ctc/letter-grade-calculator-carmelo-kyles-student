using System;

public class program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Enter the number score you have in class.");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 100)
        {
        Console.WriteLine("Wow! 100…That’s impressive! ");

        }
        else if (grade >= 95)
        {
        Console.WriteLine("Very nice! ");

        }
        else if (grade >= 80)
        {
        Console.WriteLine("Keep it up! ");

        }
        else if (grade >= 70)
        {
        Console.WriteLine("You got this, keep working! ");

        }
        else if (grade >= 60)
        {
        Console.WriteLine("Keep trying!  ");

        }
        else
        {
        Console.WriteLine("Don’t give up! ");

        }












    }
}