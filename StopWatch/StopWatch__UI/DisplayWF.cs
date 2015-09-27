using System;
using System.Runtime.Serialization.Formatters;

namespace StopWatch__UI
{
    public class DisplayWF
    {
        public void Execute()
        {
            var stopwatch = new StopWatch__BLL.StopWatch();
            while (true)
            {
                string user = getUserChoice();
                RunUserChoice(stopwatch, user);
                if (user == "5")
                    break; 
            }
        }

        public string getUserChoice()
        {
            string userChoice;
            do
            {
                int result_int;
                Console.WriteLine("Press 1 to start, 2 to stop, 3 to display, 4 to Reset, 5 to Quit");
                userChoice = Console.ReadLine();
                if (int.TryParse(userChoice, out result_int) && result_int > 0 && result_int < 6)
                    break;
            } while (true); 
            return userChoice;
        }

        public void RunUserChoice(StopWatch__BLL.StopWatch stopWatch1, string userChoice)
        {
            try
            {
                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("*START*");
                        stopWatch1.Start();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("*STOP*");
                        stopWatch1.Stop();
                        break;
                    case "3":
                        if (stopWatch1.Laps.Count != 0)
                        {
                            int lapID = 1;
                            foreach (var lap in stopWatch1.Laps)
                            {
                                Console.WriteLine($"Lap ({lapID}) result: {lap.TotalSeconds}sec");
                                lapID++;
                            }
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No record to display.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "4":
                        stopWatch1.Reset();
                        Console.WriteLine("Time watch has been resetted.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey(); 
            }
        }
    }
}