using System;

public class Resume
{
    public string _personName;

    public List<Job> _jobList = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobList)
        {
            job.DisplayJobDetails();
        }
    }

    
}