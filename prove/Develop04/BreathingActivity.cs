using System;

namespace mindfulness
{
    public class BreathingActivity : Activity
    {  
        public BreathingActivity()
        {
            SetName("Breathing Activity");
            SetDescription("This activity will help you relax doing a breathing exercise. Breathe in and out slowly. Clear your mind and focus on your breathing.");
        }

        public void Run()
        {
            DateTime futureTime = GetFutureTime(GetDuration());
            DateTime currentTime = GetCurrentTime();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);

            while (currentTime <= futureTime)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountDown(3);
                Console.WriteLine();
                Console.Write("Breathe out...");
                ShowCountDown(3);
                currentTime = DateTime.Now;
            }
        }
    }
}