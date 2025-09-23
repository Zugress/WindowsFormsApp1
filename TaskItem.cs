using System;

namespace AdvancedToDoList
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Priority { get; set; } 
        public string Category { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, string priority, string category, DateTime dueDate)
        {
            Title = title;
            Priority = priority;
            Category = category;
            DueDate = dueDate;
            IsCompleted = false; 
        }

        public override string ToString()
        {
            string status = IsCompleted ? "[V]" : "[ ]";
            return $"{status} {Title} | {Priority} | {Category} | {DueDate.ToShortDateString()}";
        }
    }
}