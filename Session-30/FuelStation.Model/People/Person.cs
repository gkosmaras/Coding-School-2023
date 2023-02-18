using FuelStation.Model.Transactions;

namespace FuelStation.Model.People
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}