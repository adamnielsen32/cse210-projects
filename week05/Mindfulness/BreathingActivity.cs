public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.", duration)
    {
       
    }

    public void Run()
    {
        DisplayStartingMessage();

        int cycleTime = 6; 
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(3);
            Console.WriteLine();    
        }

        DisplayEndingMessage();
    }
}
