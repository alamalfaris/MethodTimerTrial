using MethodTimer;

namespace MethodTimerTrial
{
    internal class Program
    {
        [Time]
        static void Main(string[] args)
        {
            Loop10();
            Loop1000();
        }

        [Time]
        static void Loop10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        [Time]
        static void Loop1000()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
