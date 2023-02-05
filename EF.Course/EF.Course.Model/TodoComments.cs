namespace EF.Course.Model
{
    public class TodoComment : EntityBase
    {
        public TodoComment(string text)
        {
            Text = text;
        }


        public string Text { get; set; }

        // Relations
        public int TodoId { get; set; }
        public Todo Todo { get; set; } = null!;
    }
}
