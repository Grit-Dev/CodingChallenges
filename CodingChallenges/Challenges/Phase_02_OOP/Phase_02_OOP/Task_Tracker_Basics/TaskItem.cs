namespace CodingChallenges.Challenges.Phase_02_OOP.Task_Tracker_Basics
{
    public class TaskItem
    {
        public string Title { get; set; } = string.Empty;

        public string Priority { get; set; } = string.Empty;

        public bool IsComplete { get; set; }

        public TaskItem(string title, string priority)
        {
            Title = title;
            Priority = priority;
            IsComplete = false;
        }

        public void MarkComplete()
        {
            IsComplete = true;
        }
    }
}