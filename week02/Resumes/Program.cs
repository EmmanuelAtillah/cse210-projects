using System;


class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Micrisoft";
        job1._jobtTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobtTitle = "Software Manager";
        job2._startYear = 2025;
        job2._endYear = 2027;

        Resume resume = new Resume();
        resume._name = "Emmanuel Atillah";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();








    }
}