using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job();

    job1._jobTitle = "Data scientist";
    job1._company = "Google";
    job1.DisplayCompany();

    Job job2 = new Job();

    job2._company = "Facebook";
    job2.DisplayCompany();
  }
}