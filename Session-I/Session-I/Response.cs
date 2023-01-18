namespace Session_I
{
    public class Response : Entity
    {
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        public Response()
        {
            ResponseID = Guid.NewGuid();
        }
    }
}
