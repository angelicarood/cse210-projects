using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job();

    job1._jobTitle = "Data scientist";
    job1._company = "Google";
    job1._startYear = 2000;
    job1._endYear = 2015;
    job1.DisplayJobDetails();

    Job job2 = new Job();

    job2._jobTitle = "Software engineer";
    job2._company = "Facebook";
    job2._startYear = 2005;
    job2._endYear = 2020;
    job2.DisplayJobDetails();

    Resume resume1 = new Resume();
    resume1._name = "Selena quintanilla";
    resume1._jobs.Add(job1);
    resume1._jobs.Add(job2);

    resume1.DisplayResumeDetails();




  }
}