using System;

class NewProgram
{
    static void Main(string[] args)
    {
         Console.Write("How many students are there in your class: ");
         int numberOfStudents = Convert.ToInt32(Console.ReadLine());
         string[] studentNames = new string[numberOfStudents];
         for (i=0;i<numberOfStudents.Length;i++)
         {
             studentNames[] += Console.ReadLine();
         }
         Array.Sort(studentNames);
         Console.WriteLine("----------------------");
         for (i=0;i<numberOfStudents.Length;i++)
         {
             Console.WriteLine(studentNames);
         }
         
         
         Console.ReadKey();
    }
}