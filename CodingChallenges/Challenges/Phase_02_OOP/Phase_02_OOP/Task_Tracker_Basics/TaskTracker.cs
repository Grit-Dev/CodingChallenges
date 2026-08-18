namespace CodingChallenges.Challenges.Phase_02_OOP.Task_Tracker_Basics
{
    public class TaskTracker
    {
        public List<TaskItem> Tasks { get; } = [];

        public void AddTask(TaskItem task)
        {
            if (task is not null)
            {
                Tasks.Add(task);
            }
        }

        public int CountIncompleteTasks()
        {
            int counter = 0;

            foreach (TaskItem task in Tasks)
            {
                if (task.IsComplete == false)
                {
                    counter++;
                }
            }

            return counter;
        }

        public int CountTasksByPriority(string priority)
        {
            if (string.IsNullOrWhiteSpace(priority))
            {
                return 0;
            }

            int counter = 0;

            foreach (TaskItem task in Tasks)
            {
                if (task.Priority.Equals(priority, StringComparison.OrdinalIgnoreCase))
                {
                    counter++;
                }
            }

            return counter;
        }

        public bool CompleteTaskByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return false;
            }

            foreach (TaskItem task in Tasks)
            {
                if (task.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    task.MarkComplete();
                    return true;
                }
            }

            return false;
        }
    }
}