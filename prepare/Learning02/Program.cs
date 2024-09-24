using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        Job job2 =  new Job();

        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        //resume info, new instance

        Resume resume1 = new Resume();

        resume1._personName = "Allison Rose";

        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        resume1.DisplayResumeDetails();

    }
}