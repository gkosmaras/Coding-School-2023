namespace EF.Course.Model
{
    public class TodoInfo : EntityBase
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Details { get; set; }

        // Relations
        public int TodoId { get; set; }
        public Todo Todo { get; set; } = null!;
    }
}
