using System.Runtime.CompilerServices;

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Resume for {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }

    
}