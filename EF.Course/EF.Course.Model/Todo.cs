using System.ComponentModel.DataAnnotations;

namespace EF.Course.Model
{
    public class Todo : EntityBase
    {
        public Todo(string title)
        {
            Title = title;
            TodoComments = new List<TodoComment>();
        }

        [Required]
        public string Title { get; set; }

        public bool Finished { get; set; }

        // Relations

        public TodoInfo TodoInfo { get; set; } = null!;
        public List<TodoComment> TodoComments { get; set; }
    }
}
