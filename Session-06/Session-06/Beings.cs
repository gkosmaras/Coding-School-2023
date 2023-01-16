namespace Beings
{
    public class Person
    {
        // 3 Properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        
        public Person()
        {

        }
        public Person(Guid id)
        {
            ID = id;
        }
        public Person(Guid id, string name)
            : this (id)
        {
            Name = name;
        }
        public Person(Guid id, string name, int age)
            : this (id, name)
        {
            Age = age;
        }

        public void GetName()
        {

        }
        public void SetName(string name)
        {

        }
    }
}