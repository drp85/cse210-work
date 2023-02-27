using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Dev";
        job1._company = "Aeroman";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "Manahmana";
        job2._startYear = 2015;
        job2._endYear = 2016;

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Gabriel Solamao";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}