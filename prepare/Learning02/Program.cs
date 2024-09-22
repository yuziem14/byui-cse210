using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._jobTitle = "Software Architect";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}