using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Console.Write("How many students are in the class? ");
    //     int numberOfStudents = Convert.ToInt32(Console.ReadLine());
    //     
    //     Console.WriteLine("Please enter the names of the students:");
    //     string[] students = new string[numberOfStudents];
    //     
    //     for (int i = 0; i < numberOfStudents; i++)
    //     {
    //         students[i] = Console.ReadLine();
    //     }
    //     
    //     Array.Sort(students);
    //     Console.WriteLine("-----------------------");
    //     
    //     for (int i = 0; i < students.Length; i++)
    //     {
    //         Console.WriteLine(students[i]);
    //     }
    //     
    //     Console.ReadKey();
    // }

    static void Main(string[] args)
    {
        Console.WriteLine($"Enter a sentence:");
        string sentence = Console.ReadLine();
        int wordCount = CountWordsInSentence(sentence);
        Console.WriteLine($"There are {wordCount} words in the sentence.");
        
        
        Console.ReadKey();
    }

    static int CountWordsInSentence(string sentence)
    {
        int wordCount = sentence.Split(' ').Length;
        return wordCount;
    }
}