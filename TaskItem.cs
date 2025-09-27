using System;

namespace AdvancedToDoList
{
    public enum PriorityLevel
    {
        High,      
        Medium,    
        Low        
    }

    public enum CategoryType
    {
        Work,
        Home,
        Hobby
    }
    public class TaskItem
    {
        public string Title { get; set; }
        public PriorityLevel Priority { get; set; } 
        public CategoryType Category { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            string status = IsCompleted ? "[✓]" : "[ ]";
            return $"{status} {Title} | Приоритет: {Priority} | Категория: {Category} | До: {DueDate.ToShortDateString()}";
        }

        public TaskItem(string title, PriorityLevel priority, CategoryType category, DateTime dueDate, string description)
        {
            Title = title;
            Priority = priority;
            Category = category;
            DueDate = dueDate;
            Description = description;
            IsCompleted = false;
        }
    }
}