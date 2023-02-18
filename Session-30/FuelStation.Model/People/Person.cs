using FuelStation.Model.Transactions;

namespace FuelStation.Model.People
{
    public class Person : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public List<Transaction>? Transactions { get; set; }
    }
}