using System;

namespace mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string> {
            "Think of a scenario where you stood up for someone else.",
            "Think of a situation when you faced a truly difficult task.",
            "Think of a moment when you extended help to someone in need.",
            "Think of an experience where you demonstrated genuine selflessness.",
            "Think of a time when you took a risk to support a worthy cause.",
            "Think of an occasion when you overcame a major obstacle through perseverance.", 
            "Think of an incident where you went out of your way to make someone's day better.",
            "Think of a memory when you prioritized the needs of others above your own.",
            "Think of a moment when you confronted and addressed an injustice or unfairness.",
            "Think of an experience where you demonstrated exceptional empathy towards someone in distress.",
            "Think of a memory when you generously shared your knowledge or expertise to benefit others.",
        };
        private List<string> _questions = new List<string> {
            "What differentiates this occasion from previous ones where you were less successful?",
            "What aspect of this experience resonated with you the most?",
            "What broader applications or lessons can you derive from this experience?",
            "What self-discoveries did you make through this encounter?",
            "How can you integrate the insights gained from this experience into future endeavors?",
            "What significance does this experience hold for you?",
            "Have you previously encountered a similar situation?",
            "What were the initial steps you took to initiate this process?",
            "How did you feel upon completing the task?",
        };

        public ReflectingActivity()
        {
            SetName("Reflecting Activity");
            SetDescription("This activity will help ou reflect on times in your life where you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }

        public void Run()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter.");
            Console.ReadLine();
            Console.Clear();

            DateTime futureTime = GetFutureTime(GetDuration());
            DateTime currentTime = GetCurrentTime();

            while (currentTime <= futureTime)
            {
                string question = GetRandomQuestion();
                Console.Write($"{question} ");
                ShowSpinner(30);
                Console.WriteLine();
                Console.WriteLine();
                currentTime = DateTime.Now;
            }
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(0, _prompts.Count);
            return _prompts[index];
        }
        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(0, _questions.Count);
            return _questions[index];
        }
    }
}