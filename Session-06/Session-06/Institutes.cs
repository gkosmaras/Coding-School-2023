using Students;
using Lessons;
using Score;
using Calendar;

namespace Institutes
{
    public class Institute
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        public Institute()
        {

        }
        public Institute(Guid id)
        {
            ID = id;
        }
        public Institute(Guid id, string name)
            : this(id)
        {
            Name = name;
        }
        public Institute(Guid id, string name, int years)
            : this(id, name)
        {
            YearsInService = years;
        }
        public void GetName()
        {

        }
        public void SetName(string name)
        {

        }
    }
}