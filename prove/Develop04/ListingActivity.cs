using System;

namespace mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some attributes that you admire in others?",
            "When was the last time you felt a deep sense of gratitude?",
        };

        public ListingActivity()
        {
            SetName("Listing Activity");
            SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }
        public void Run()
        {   
            int itemCount = 0;
            string prompt = GetRandomPrompt();
            Console.WriteLine();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();
                    
            DateTime futureTime = GetFutureTime(GetDuration());
            DateTime currentTime = GetCurrentTime();

            while (currentTime <= futureTime)
            {
                Console.Write(">");
                Console.ReadLine();
                itemCount++;
                currentTime = DateTime.Now;
            }
            Console.WriteLine($"You entered {itemCount} responses.");
        }
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(0, _prompts.Count);
            return _prompts[index];
        }
    }
}