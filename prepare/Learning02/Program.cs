using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "CPhT";
        job1._company = "Akina";
        job1._startYear = 2024;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "BYU-I";
        job2._startYear = 2017;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "Student";
        job3._company = "BYU-Pathway";
        job3._startYear = 2023;
        job3._endYear = 9999;

        Resume resume = new Resume();
        resume._name = "Brandon A";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        resume.DisplayResume();

    }
}