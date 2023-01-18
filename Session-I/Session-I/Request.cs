namespace Session_I
{
    public class Entity
    {
        public Guid RequestID { get; set; }
    }

    public class Request : Entity
    {
        public string Input { get; set; }
        public Picker Action { get; set; }

        public Request()
        {
            RequestID = Guid.NewGuid();
        }
    }
}
