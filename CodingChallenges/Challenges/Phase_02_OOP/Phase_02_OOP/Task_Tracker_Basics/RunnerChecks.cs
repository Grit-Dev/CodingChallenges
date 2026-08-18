namespace CodingChallenges.Challenges.Phase_02_OOP.Task_Tracker_Basics
{
    public class RunnerChecks
    {
        public static void Run()
        {
            var tracker = new TaskTracker();

            var taskOne = new TaskItem("Practise C#", "High");
            var taskTwo = new TaskItem("Update README", "Low");
            var taskThree = new TaskItem("Review OOP", "High");

            tracker.AddTask(taskOne);
            tracker.AddTask(taskTwo);
            tracker.AddTask(taskThree);

            Console.WriteLine(tracker.CountIncompleteTasks() == 3);
            Console.WriteLine(tracker.CountTasksByPriority("High") == 2);
            Console.WriteLine(tracker.CountTasksByPriority("high") == 2);
            Console.WriteLine(tracker.CountTasksByPriority("Low") == 1);

            Console.WriteLine(tracker.CompleteTaskByTitle("Update README") == true);
            Console.WriteLine(taskTwo.IsComplete == true);
            Console.WriteLine(tracker.CountIncompleteTasks() == 2);

            Console.WriteLine(tracker.CompleteTaskByTitle("Missing Task") == false);
            Console.WriteLine(tracker.CountIncompleteTasks() == 2);
        }
    }
}