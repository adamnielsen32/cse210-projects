using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2020";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Data Scientist";
        job2._startYear = "2019";
        job2._endYear = "2021";
       


        Resume resume = new Resume();
        resume._name = "John Doe";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.DisplayResume();
    }
}